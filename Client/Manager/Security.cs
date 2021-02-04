using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace Client.Manager
{
    class Security
    {
        public static string Encrypt(string text)
        {
            SHA256 mySHA256 = SHA256Managed.Create();
            byte[] key = mySHA256.ComputeHash(Encoding.UTF8.GetBytes(CSystem.GetHashedDisk().ToString()));
            byte[] iv = new byte[16] { 0x1, 0x7, 0x0, 0x6, 0x2, 0x0, 0x0, 0x0, 0x1, 0x6, 0x1, 0x7, 0x1, 0x8, 0x1, 0x9 };

            Aes encryptor = Aes.Create();

            encryptor.Mode = CipherMode.CBC;

            byte[] aesKey = new byte[32];
            Array.Copy(key, 0, aesKey, 0, 32);
            encryptor.Key = aesKey;
            encryptor.IV = iv;

            MemoryStream memoryStream = new MemoryStream();

            ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();

            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);

            byte[] plainBytes = Encoding.UTF8.GetBytes(text);

            cryptoStream.Write(plainBytes, 0, plainBytes.Length);

            cryptoStream.FlushFinalBlock();

            byte[] cipherBytes = memoryStream.ToArray();

            memoryStream.Close();
            cryptoStream.Close();

            byte[] PackBytes = Encoding.UTF8.GetBytes(Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length));

            StringBuilder Result = new StringBuilder(PackBytes.Length * 2);
            string HexAlphabet = "0123456789abcdef";

            foreach (byte B in PackBytes)
            {
                Result.Append(HexAlphabet[(int)(B >> 4)]);
                Result.Append(HexAlphabet[(int)(B & 0xF)]);
            }

            return Result.ToString();
        }

        public static string Decrypt(string text)
        {
            if (text == "")
                return string.Empty;

            SHA256 mySHA256 = SHA256Managed.Create();
            byte[] key = mySHA256.ComputeHash(Encoding.UTF8.GetBytes(CSystem.GetHashedDisk().ToString()));
            byte[] iv = new byte[16] { 0x1, 0x7, 0x0, 0x6, 0x2, 0x0, 0x0, 0x0, 0x1, 0x6, 0x1, 0x7, 0x1, 0x8, 0x1, 0x9 };

            Aes encryptor = Aes.Create();

            encryptor.Mode = CipherMode.CBC;

            byte[] aesKey = new byte[32];
            Array.Copy(key, 0, aesKey, 0, 32);
            encryptor.Key = aesKey;
            encryptor.IV = iv;


            MemoryStream memoryStream = new MemoryStream();

            ICryptoTransform aesDecryptor = encryptor.CreateDecryptor();

            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);

            string plainText = String.Empty;

            try
            {
                byte[] Bytes = new byte[text.Length / 2];
                int[] HexValue = new int[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F };

                for (int x = 0, i = 0; i < text.Length; i += 2, x += 1)
                    Bytes[x] = (byte)(HexValue[Char.ToUpper(text[i + 0]) - '0'] << 4 | HexValue[Char.ToUpper(text[i + 1]) - '0']);

                text = Encoding.UTF8.GetString(Bytes);

                byte[] cipherBytes = Convert.FromBase64String(text);

                cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);

                cryptoStream.FlushFinalBlock();

                byte[] plainBytes = memoryStream.ToArray();

                plainText = Encoding.UTF8.GetString(plainBytes, 0, plainBytes.Length);
            }
            finally
            {
                memoryStream.Close();
                cryptoStream.Close();
            }

            return plainText;
        }
    }
}
