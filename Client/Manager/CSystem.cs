using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;

namespace Client.Manager
{
    class CSystem
    {
		private static string _DiskId;
		private static Guid? _HashedDiskId;
		private static object HashedDiskIdLock = new object();
		private static object DiskIdLock = new object();

		public static string GetTime()
		{
			int Hour = int.Parse(DateTime.Now.ToString("HH"));
			if (Hour < 4 || Hour >= 22) return Globals.m_Interface.m_goodNight;
			if (Hour < 12) return Globals.m_Interface.m_goodMorning;
			if (Hour < 16) return Globals.m_Interface.m_goodDay;
			return Globals.m_Interface.m_goodEvening;
		}

		public static string RandomString(int letters, int numbers)
		{
			Random rnd = new Random();
			StringBuilder sb = new StringBuilder(letters + numbers);
			string letterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			string numberSet = "0123456789";
			for (int i = 0; i < letters; i++)
				sb.Append(letterSet[rnd.Next(letterSet.Length)]);
			for (int i = 0; i < numbers; i++)
				sb.Append(numberSet[rnd.Next(numberSet.Length)]);
			return sb.ToString();
		}

		public static string GetOSInfo()
		{
			var osVersionInfo = new WinAPI.OSVERSIONINFOEX { OSVersionInfoSize = Marshal.SizeOf(typeof(WinAPI.OSVERSIONINFOEX)) };
			if (WinAPI.RtlGetVersion(ref osVersionInfo) != 0)
			{
				return "Not found version";
			}

			return $"{osVersionInfo.MajorVersion}.{osVersionInfo.MinorVersion}.{osVersionInfo.BuildNumber}";
		}

		public static ulong GetRamSize()
        {
			WinAPI.MEMORYSTATUSEX memStatus = new WinAPI.MEMORYSTATUSEX();
			if (WinAPI.GlobalMemoryStatusEx(memStatus))
				return memStatus.ullTotalPhys;

			return 0;
		}

		public static double PingTimeAverage(string host, int echoNum)
		{
			Uri uri = new Uri(host);
			long totalTime = 0;
			int timeout = 120;
			Ping pingSender = new Ping();

			for (int i = 0; i < echoNum; i++)
			{
				PingReply reply = pingSender.Send(uri.Host, timeout);
				if (reply.Status == IPStatus.Success)
				{
					totalTime += reply.RoundtripTime;
				}
			}
			return totalTime / echoNum;
		}

        public static string GetUserTilePath(string username)
        {
            var sb = new StringBuilder(1000);
            WinAPI.GetUserTilePath(username, 0x80000000, sb, sb.Capacity);
            return sb.ToString();
        }

        public static Image GetUserTile(string username)
        {
            return Image.FromFile(GetUserTilePath(username));
        }

		public static string GetDiskInfo()
		{
			lock (DiskIdLock)
			{
				if (!string.IsNullOrEmpty(_DiskId)) return _DiskId;
				string vendorId = "";
				string productId = "";
				string productRevision = "";
				string serialNumber = "";
				GetDiskDriveId(0, out vendorId, out productId, out productRevision, out serialNumber);
				var values = new List<string>();
				if (!string.IsNullOrEmpty(vendorId)) values.Add($"VN={vendorId}");
				if (!string.IsNullOrEmpty(productId)) values.Add($"PR={productId}");
				if (!string.IsNullOrEmpty(productRevision)) values.Add($"RV={productRevision}");
				if (!string.IsNullOrEmpty(serialNumber)) values.Add($"SN={serialNumber}");
				_DiskId = string.Join(",", values);
			}
			return _DiskId;
		}

		public static Guid GetHashedDisk()
		{
			lock (HashedDiskIdLock)
			{
				if (_HashedDiskId.HasValue) return _HashedDiskId.Value;
				var diskId = GetDiskInfo();
				if (string.IsNullOrEmpty(diskId)) return Guid.Empty;
				var serialBytes = Encoding.ASCII.GetBytes(diskId);
				var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
				byte[] retVal = md5.ComputeHash(serialBytes);
				_HashedDiskId = new Guid(retVal);
			}
			return _HashedDiskId.Value;
		}

		public static Exception GetDiskDriveId(int id, out string vendorId, out string productId, out string productRevision, out string serialNumber)
		{
			vendorId = "";
			productId = "";
			productRevision = "";
			serialNumber = "";
			string lpFileName = string.Format(@"\\.\PhysicalDrive{0}", id);
			UInt32 dwDesiredAccess = 0;
			UInt32 dwShareMode = WinAPI.FILE_SHARE_WRITE | WinAPI.FILE_SHARE_READ;
			IntPtr lpSecurityAttributes = default(IntPtr);
			UInt32 dwCreationDisposition = WinAPI.OPEN_EXISTING;
			UInt32 dwFlagsAndAttributes = 0;
			IntPtr hTemplateFile = default(IntPtr);
			Exception error = null;
			var deviceHandle = WinAPI.CreateFile(lpFileName, dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
			if (deviceHandle == null || deviceHandle.IsInvalid)
			{
				error = new Win32Exception(Marshal.GetLastWin32Error());
			}
			else
			{
				WinAPI.STORAGE_PROPERTY_QUERY query = new WinAPI.STORAGE_PROPERTY_QUERY() { PropertyId = 0, QueryType = 0 };
				var inputBufferSize = Marshal.SizeOf(query.GetType());
				var inputBuffer = Marshal.AllocHGlobal(inputBufferSize);
				Marshal.StructureToPtr(query, inputBuffer, true);
				uint ioControlCode = WinAPI.IOCTL_STORAGE_QUERY_PROPERTY;
				var headerBufferSize = Marshal.SizeOf(typeof(WinAPI.STORAGE_DESCRIPTOR_HEADER));
				var headerBuffer = Marshal.AllocHGlobal(headerBufferSize);
				var headerBytesReturned = default(UInt32);
				var success = WinAPI.DeviceIoControl(deviceHandle, ioControlCode, inputBuffer, inputBufferSize, headerBuffer, headerBufferSize, ref headerBytesReturned, IntPtr.Zero);
				if (!success)
				{
					error = new Win32Exception(Marshal.GetLastWin32Error());
				}
				else if (headerBytesReturned != headerBufferSize)
				{
					error = new InvalidOperationException("Bad header structure declaration");
				}
				else
				{
					var header = (WinAPI.STORAGE_DESCRIPTOR_HEADER)Marshal.PtrToStructure(headerBuffer, typeof(WinAPI.STORAGE_DESCRIPTOR_HEADER));
					var descriptorBufferSize = header.Size;
					var descriptorBufferPointer = Marshal.AllocHGlobal(descriptorBufferSize);
					var descriptorBytesReturned = default(UInt32);
					success = WinAPI.DeviceIoControl(deviceHandle, ioControlCode, inputBuffer, inputBufferSize, descriptorBufferPointer, descriptorBufferSize, ref descriptorBytesReturned, IntPtr.Zero);
					if (!success)
					{
						error = new Win32Exception(Marshal.GetLastWin32Error());
					}
					else if (headerBytesReturned != headerBufferSize)
					{
						error = new InvalidOperationException("Bad descriptor structure declaration");
					}
					else
					{
						var descriptor = (WinAPI.STORAGE_DEVICE_DESCRIPTOR)Marshal.PtrToStructure(descriptorBufferPointer, typeof(WinAPI.STORAGE_DEVICE_DESCRIPTOR));
						byte[] descriptorBuffer = new byte[descriptorBufferSize];
						Marshal.Copy(descriptorBufferPointer, descriptorBuffer, 0, descriptorBuffer.Length);
						vendorId = WinAPI.GetString(descriptorBuffer, descriptor.VendorIdOffset);
						productId = WinAPI.GetString(descriptorBuffer, descriptor.ProductIdOffset);
						productRevision = WinAPI.GetString(descriptorBuffer, descriptor.ProductRevisionOffset);
						serialNumber = WinAPI.GetString(descriptorBuffer, descriptor.SerialNumberOffset);
					}
					Marshal.FreeHGlobal(descriptorBufferPointer);
				}
				Marshal.FreeHGlobal(headerBuffer);
				Marshal.FreeHGlobal(inputBuffer);
			}
			deviceHandle.Dispose();
			deviceHandle = null;
			return error;
		}
	}
}
