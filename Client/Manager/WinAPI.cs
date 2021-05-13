using System;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.Win32;
using System.Security.Permissions;
using System.Security;

namespace Client.Manager
{
    class WinAPI
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct STORAGE_DESCRIPTOR_HEADER
        {
            public Int32 Version;
            public Int32 Size;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct STORAGE_DEVICE_DESCRIPTOR
        {
            public Int32 Version;
            public Int32 Size;
            public byte DeviceType;
            public byte DeviceTypeModifier;
            public byte RemovableMedia;
            public byte CommandQueueing;
            public Int32 VendorIdOffset;
            public Int32 ProductIdOffset;
            public Int32 ProductRevisionOffset;
            public Int32 SerialNumberOffset;
            public byte BusType;
            public Int32 RawPropertiesLength;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
            public byte[] RawDeviceProperties;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct STORAGE_PROPERTY_QUERY
        {
            public Int32 PropertyId;
            public Int32 QueryType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
            public byte[] AdditionalParameters;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public enum eDesiredAccess : int
        {
            DELETE = 0x00010000,
            READ_CONTROL = 0x00020000,
            WRITE_DAC = 0x00040000,
            WRITE_OWNER = 0x00080000,
            SYNCHRONIZE = 0x00100000,
            STANDARD_RIGHTS_ALL = 0x001F0000,

            PROCESS_TERMINATE = 0x0001,
            PROCESS_CREATE_THREAD = 0x0002,
            PROCESS_SET_SESSIONID = 0x0004,
            PROCESS_VM_OPERATION = 0x0008,
            PROCESS_VM_READ = 0x0010,
            PROCESS_VM_WRITE = 0x0020,
            PROCESS_DUP_HANDLE = 0x0040,
            PROCESS_CREATE_PROCESS = 0x0080,
            PROCESS_SET_QUOTA = 0x0100,
            PROCESS_SET_INFORMATION = 0x0200,
            PROCESS_QUERY_INFORMATION = 0x0400,
            PROCESS_ALL_ACCESS = SYNCHRONIZE | 0xFFF
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_BASIC_INFORMATION
        {
            public uint ExitStatus;
            public IntPtr PebBaseAddress;
            public UIntPtr AffinityMask;
            public int BasePriority;
            public UIntPtr UniqueProcessId;
            public UIntPtr InheritedFromUniqueProcessId;

            public uint Size
            {
                get
                {
                    unsafe
                    {
                        return (uint)sizeof(PROCESS_BASIC_INFORMATION);
                    }
                }
            }
        };

        public enum PROCESSINFOCLASS : int
        {
            ProcessBasicInformation = 0,
            ProcessQuotaLimits,
            ProcessIoCounters,
            ProcessVmCounters,
            ProcessTimes,
            ProcessBasePriority,
            ProcessRaisePriority,
            ProcessDebugPort,
            ProcessExceptionPort,
            ProcessAccessToken,
            ProcessLdtInformation,
            ProcessLdtSize,
            ProcessDefaultHardErrorMode,
            ProcessIoPortHandlers, // Note: this is kernel mode only
            ProcessPooledUsageAndLimits,
            ProcessWorkingSetWatch,
            ProcessUserModeIOPL,
            ProcessEnableAlignmentFaultFixup,
            ProcessPriorityClass,
            ProcessWx86Information,
            ProcessHandleCount,
            ProcessAffinityMask,
            ProcessPriorityBoost,
            MaxProcessInfoClass
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public class MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;
            public MEMORYSTATUSEX()
            {
                this.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct OSVERSIONINFOEX
        {
            internal int OSVersionInfoSize;
            internal int MajorVersion;
            internal int MinorVersion;
            internal int BuildNumber;
            internal int PlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            internal string CSDVersion;
            internal ushort ServicePackMajor;
            internal ushort ServicePackMinor;
            internal short SuiteMask;
            internal byte ProductType;
            internal byte Reserved;
        }

        public const int SWP_NOSIZE = 0x0001;
        public const int SWP_NOZORDER = 0x0004;
        public const int SWP_SHOWWINDOW = 0x0040;

        public const UInt32 DISK_BASE = 0x00000007;
        public const UInt32 METHOD_BUFFERED = 0;
        public const UInt32 FILE_ANY_ACCESS = 0;

        public const UInt32 GENERIC_READ = 0x80000000;
        public const UInt32 FILE_SHARE_WRITE = 0x2;
        public const UInt32 FILE_SHARE_READ = 0x1;
        public const UInt32 OPEN_EXISTING = 0x3;

        public static uint IOCTL_STORAGE_QUERY_PROPERTY = CTL_CODE(IOCTL_STORAGE_BASE, 0x500, METHOD_BUFFERED, FILE_ANY_ACCESS);

        public const uint FILE_DEVICE_MASS_STORAGE = 0x2d;
        public const uint IOCTL_STORAGE_BASE = FILE_DEVICE_MASS_STORAGE;

        public const uint ERROR_ACCESS_DENIED = 0x5;

        [SecurityCritical]
        [DllImport("ntdll.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern int RtlGetVersion(ref OSVERSIONINFOEX versionInfo);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder title, int size);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowThreadProcessId(IntPtr handle, out uint processId);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("shell32.dll", EntryPoint = "#261", CharSet = CharSet.Unicode, PreserveSig = false)]
        public static extern void GetUserTilePath(string username, UInt32 whatever, StringBuilder picpath, int maxLength);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern SafeFileHandle CreateFile(string lpFileName, UInt32 dwDesiredAccess, UInt32 dwShareMode, IntPtr lpSecurityAttributes, UInt32 dwCreationDisposition, UInt32 dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool DeviceIoControl(SafeFileHandle hDevice, uint dwIoControlCode, IntPtr lpInBuffer, int nInBufferSize, IntPtr lpOutBuffer, int nOutBufferSize, ref UInt32 lpBytesReturned, IntPtr lpOverlapped);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        [DllImport("kernel32.dll")]
        public static extern SafeProcessHandle OpenProcess(eDesiredAccess dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

        [DllImport("ntdll.dll")]
        public static extern int NtQueryInformationProcess(SafeProcessHandle hProcess, PROCESSINFOCLASS pic, ref PROCESS_BASIC_INFORMATION pbi, uint cb, ref int pSize);

        #region Helpers

        [PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
        public static Process ElevateProcess(Process source)
        {
            Process target = new Process();
            target.StartInfo = source.StartInfo;
            target.StartInfo.FileName = source.MainModule.FileName;
            target.StartInfo.WorkingDirectory = Path.GetDirectoryName(source.MainModule.FileName);

            target.StartInfo.UseShellExecute = true;
            target.StartInfo.Verb = "runas";

            try
            {
                if (!target.Start())
                    return null;
            }
            catch (Win32Exception e)
            {
                if (e.NativeErrorCode == 1223)
                    return null;
                throw new Exception("Unable to restart when prompted for administrator rights");
            };
            return target;
        }

        public static bool RegistryValueExists(RegistryKey Key, string Value)
        {
            try
            {
                return Key.GetValue(Value) != null;
            }
            catch
            {
                return false;
            }
        }

        public static int GetParentProcessId(int processId)
        {
            int ParentID = 0;
            SafeProcessHandle hProcess = OpenProcess(eDesiredAccess.PROCESS_QUERY_INFORMATION, false, processId);

            if (!hProcess.IsInvalid)
            {
                try
                {
                    PROCESS_BASIC_INFORMATION pbi = new PROCESS_BASIC_INFORMATION();
                    int pSize = 0;

                    if (0 == NtQueryInformationProcess(hProcess, PROCESSINFOCLASS.ProcessBasicInformation, ref pbi, pbi.Size, ref pSize))
                    {
                        ParentID = (int)pbi.InheritedFromUniqueProcessId;
                    }
                }
                finally
                {
                    hProcess.Dispose();
                }
            }


            return ParentID;
        }

        public static List<KeyValuePair<int, SafeProcessHandle>> GetChildProcessIds(int parentProcessId, DateTime parentStartTime)
        {
            List<KeyValuePair<int, SafeProcessHandle>> myChildren = new List<KeyValuePair<int, SafeProcessHandle>>();

            foreach (Process possibleChildProcess in Process.GetProcesses())
            {
                using (possibleChildProcess)
                {
                    SafeProcessHandle childHandle = OpenProcess(eDesiredAccess.PROCESS_QUERY_INFORMATION, false, possibleChildProcess.Id);
                    if (childHandle.IsInvalid)
                    {
                        continue;
                    }

                    bool keepHandle = false;
                    try
                    {
                        if (possibleChildProcess.StartTime > parentStartTime)
                        {
                            int childParentProcessId = GetParentProcessId(possibleChildProcess.Id);
                            if (childParentProcessId != 0)
                            {
                                if (parentProcessId == childParentProcessId)
                                {
                                    myChildren.Add(new KeyValuePair<int, SafeProcessHandle>(possibleChildProcess.Id, childHandle));
                                    keepHandle = true;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (!keepHandle)
                        {
                            childHandle.Dispose();
                        }
                    }
                }
            }

            return myChildren;
        }

        public static void KillTree(int processId)
        {
            Process thisProcess;
            try
            {
                thisProcess = Process.GetProcessById(processId);
            }
            catch (ArgumentException)
            {
                return;
            }

            try
            {
                DateTime myStartTime = thisProcess.StartTime;

                SafeProcessHandle hProcess = OpenProcess(eDesiredAccess.PROCESS_QUERY_INFORMATION, false, processId);
                if (hProcess.IsInvalid)
                {
                    return;
                }

                try
                {
                    try
                    {
                        thisProcess.Kill();
                    }
                    catch (Win32Exception e)
                    {
                        if (e.NativeErrorCode != ERROR_ACCESS_DENIED)
                        {
                            throw;
                        }
                    }

                    List<KeyValuePair<int, SafeProcessHandle>> children = GetChildProcessIds(processId, myStartTime);

                    try
                    {
                        foreach (KeyValuePair<int, SafeProcessHandle> childProcessInfo in children)
                        {
                            KillTree(childProcessInfo.Key);
                        }
                    }
                    finally
                    {
                        foreach (KeyValuePair<int, SafeProcessHandle> childProcessInfo in children)
                        {
                            childProcessInfo.Value.Dispose();
                        }
                    }
                }
                finally
                {
                    hProcess.Dispose();
                }
            }
            finally
            {
                thisProcess.Dispose();
            }
        }

        public static void SafeDeleteDirs(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);

            foreach (FileInfo file in di.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch
                {
                    continue;
                }
            }

            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                try
                {
                    dir.Delete(true);
                }
                catch
                {
                    continue;
                }
            }
        }

        public static IntPtr MicrosoftStoreWindow()
        {
            IntPtr handle = GetForegroundWindow();
            uint pid = 0;
            GetWindowThreadProcessId(handle, out pid);
            if (pid == 0 || Process.GetProcessById((int)pid) == null)
                return IntPtr.Zero;

            var proc = Process.GetProcessById((int)pid);
            return (proc.MainModule.FileName.ToLower().Contains("explorer.exe")) ? handle : IntPtr.Zero;
        }

        public static void SetCenter(IntPtr handle)
        {
            RECT rct;
            GetWindowRect(handle, out rct);
            Rectangle screen = Screen.FromHandle(handle).Bounds;
            Point pt = new Point(screen.Left + screen.Width / 2 - (rct.Right - rct.Left) / 2, screen.Top + screen.Height / 2 - (rct.Bottom - rct.Top) / 2);
            SetWindowPos(handle, 0x0, pt.X, pt.Y, 0, 0, SWP_NOZORDER | SWP_NOSIZE | SWP_SHOWWINDOW);
        }

        public static string GetText(IntPtr hWnd)
        {
            int length = GetWindowTextLength(hWnd);
            StringBuilder sb = new StringBuilder(length + 1);
            GetWindowText(hWnd, sb, sb.Capacity);
            return sb.ToString();
        }

        public static string GetString(byte[] bytes, int index, bool reverse = false)
        {
            if (bytes == null || bytes.Length == 0 || index <= 0 || index >= bytes.Length) return "";
            int i;
            for (i = index; i < bytes.Length; i++)
            {
                if (bytes[i] == 0) break;
            }
            if (index == i) return "";
            var valueBytes = new byte[i - index];
            Array.Copy(bytes, index, valueBytes, 0, valueBytes.Length);
            if (reverse) Array.Reverse(valueBytes);
            return Encoding.ASCII.GetString(valueBytes).Trim();
        }

        public static uint CTL_CODE(uint DeviceType, uint Function, uint Method, uint Access)
        {
            return ((DeviceType << 16) | (Access << 14) | (Function << 2) | Method);
        }

        #endregion
    }
}
