using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Void_server.Libs
{
    public static class AES
    {
        public static string Encrypt(string input, string key)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(input), Encoding.UTF8.GetBytes(key)));
        }
        
        public static string Encrypt(string input)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(input)));
        }
        
        public static byte[] Encrypt(byte[] input)
        {
            if (defaultKey == null || defaultKey.Length == 0)
            {
                throw new Exception("Key can not be empty.");
            }
            if (input == null || input.Length == 0)
            {
                throw new ArgumentException("Input can not be empty.");
            }
            byte[] result = new byte[0];
            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    memoryStream.Position = 32L;
                    using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
                    {
                        aesCryptoServiceProvider.KeySize = 128;
                        aesCryptoServiceProvider.BlockSize = 128;
                        aesCryptoServiceProvider.Mode = CipherMode.CBC;
                        aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
                        aesCryptoServiceProvider.Key = defaultKey;
                        aesCryptoServiceProvider.GenerateIV();
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
                            cryptoStream.Write(input, 0, input.Length);
                            cryptoStream.FlushFinalBlock();
                            using (HMACSHA256 hmacsha = new HMACSHA256(defaultAuthKey))
                            {
                                byte[] array = hmacsha.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
                                memoryStream.Position = 0L;
                                memoryStream.Write(array, 0, array.Length);
                            }
                        }
                    }
                    result = memoryStream.ToArray();
                }
            }
            catch
            {
            }
            return result;
        }
        
        public static byte[] Encrypt(byte[] input, byte[] key)
        {
            if (key == null || key.Length == 0)
            {
                throw new Exception("Key can not be empty.");
            }
            byte[] bytes;
            using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(key, Salt, 50000))
            {
                key = rfc2898DeriveBytes.GetBytes(16);
                bytes = rfc2898DeriveBytes.GetBytes(64);
            }
            byte[] result = new byte[0];
            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    memoryStream.Position = 32L;
                    using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
                    {
                        aesCryptoServiceProvider.KeySize = 128;
                        aesCryptoServiceProvider.BlockSize = 128;
                        aesCryptoServiceProvider.Mode = CipherMode.CBC;
                        aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
                        aesCryptoServiceProvider.Key = key;
                        aesCryptoServiceProvider.GenerateIV();
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
                            cryptoStream.Write(input, 0, input.Length);
                            cryptoStream.FlushFinalBlock();
                            using (HMACSHA256 hmacsha = new HMACSHA256(bytes))
                            {
                                byte[] array = hmacsha.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
                                memoryStream.Position = 0L;
                                memoryStream.Write(array, 0, array.Length);
                            }
                        }
                    }
                    result = memoryStream.ToArray();
                }
            }
            catch
            {
            }
            return result;
        }
        
        private const int IvLength = 16;
        
        private const int HmacSha256Length = 32;
        
        private static byte[] defaultKey;
        
        private static byte[] defaultAuthKey;
        
        public static readonly byte[] Salt = new byte[]
        {
            191,
            235,
            30,
            86,
            251,
            205,
            151,
            59,
            178,
            25,
            2,
            36,
            48,
            165,
            120,
            67,
            0,
            61,
            86,
            68,
            210,
            30,
            98,
            185,
            212,
            241,
            128,
            231,
            230,
            195,
            57,
            65
        };
    }
}
