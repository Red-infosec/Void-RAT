using Microsoft.Win32;
namespace Void_client.Libs
{
    class Registry
    {
        //adds the client path to startup (doesn't really work yet)
        public static void AddToStartup(string path)
        {
            RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            key.SetValue("Void", path);
        }

        //removes thhe client path from startup
        public static void RemoveFromStartup()
        {
            RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            key.DeleteSubKey("Void");
        }

        //checks if the key inside of a subfolder contains the value given
        public static bool ContainsKey(string subFolder, string value)
        {
            RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(subFolder, true);

            foreach (var name in key.GetSubKeyNames())
            {
                if (value == name)
                    return false;
            }

            return true;
        }
    }
}
