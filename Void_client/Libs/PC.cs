using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Void_client.Libs
{
    class PC
    {
        //allow us to make the user log off
        [DllImport("user32")]
        private static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        public static void Shutdown()
        {
            Process.Start(GetHiddenStart("shutdown", "/s /t 0"));
        }

        public static void Restart()
        {
            Process.Start(GetHiddenStart("shutdown", "/r /t 0"));
        }

        public static void LogOff()
        {
            ExitWindowsEx(0, 0);
        }

        //just sets some of the properties for the process
        private static ProcessStartInfo GetHiddenStart(string command, string parameters)
        {
            ProcessStartInfo info = new ProcessStartInfo(command, parameters);
            info.CreateNoWindow = true;
            info.UseShellExecute = false;

            return info;
        }
    }
}
