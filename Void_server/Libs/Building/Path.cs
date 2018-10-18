using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Void_server.Libs
{
    public static class Path
    {
        public static bool CheckPathForIllegalChars(string path)
        {
            return path.Any((char c) => illegalChars.Contains(c));
        }
        
        public static string GetRandomFilename(int length, string extension = "")
        {
            StringBuilder stringBuilder = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"[rand.Next("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".Length)]);
            }
            return stringBuilder.ToString() + extension;
        }
        
        public static int GetNewTransferId(int o = 0)
        {
            return rand.Next(0, int.MaxValue) + o;
        }
        
        public static string GetDataSize(long size)
        {
            double num = (double)size;
            int num2 = 0;
            while (num >= 1024.0 && num2 + 1 < sizes.Length)
            {
                num2++;
                num /= 1024.0;
            }
            return string.Format("{0:0.##} {1}", num, sizes[num2]);
        }
        
        private static readonly Random rand = new Random(Environment.TickCount);
        
        private static readonly string[] sizes = new string[]
        {
            "B",
            "KB",
            "MB",
            "GB"
        };
        
        private static readonly char[] illegalChars = System.IO.Path.GetInvalidPathChars().Union(System.IO.Path.GetInvalidFileNameChars()).ToArray<char>();
    }
}