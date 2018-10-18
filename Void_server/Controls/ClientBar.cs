using System;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;
using Void_server.Libs;

namespace Void_server.Controls
{
    public class ClientBar : Panel
    {
        //create the variables
        TextBox ipBox = new TextBox();
        TextBox nameBox = new TextBox();
        TextBox portBox = new TextBox();
        TextBox osBox = new TextBox();
        TextBox bitBox = new TextBox();
        public bool isAutoInstall = false;
        public RATSession session = new RATSession();
        public static bool SupressErrors = false;
        
        public ClientBar(TcpClient client)
        {
            //get a list of all the text boxes
            TextBox[] collection = { ipBox, nameBox, portBox, osBox, bitBox };

            //set properties
            this.BackColor = Color.DimGray;
            this.Size = new Size(746, 40);
            this.ContextMenuStrip = MainForm.clientOptions;
            ipBox.Location = new Point(8, 10);
            nameBox.Location = new Point(98, 10);
            portBox.Location = new Point(188, 10);
            osBox.Location = new Point(278, 10);
            bitBox.Location = new Point(368, 10);
            this.MouseDown += ClientBar_MouseDown;
            
            foreach (var box in collection)
            {
                box.BorderStyle = BorderStyle.FixedSingle;
                box.Size = new Size(82, 20);
                box.BackColor = this.BackColor;
                this.Controls.Add(box);
            }

            //set the bar of the session to this control and start the session
            session.bar = this;
            session.Start(client);
        }

        private void ClientBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                MainForm.currentSelectedBar = this;
        }

        public void SetProperties(params string[] information)
        {
            //set properties
            this.Invoke(new Action(() => 
            {
                //gets all the textboxes
                TextBox[] collection = { ipBox, nameBox, portBox, osBox, bitBox };

                //sets the information
                for (int i = 0; i < information.Length - 1; i++)
                    collection[i].Text = information[i];
                
                //finds out if the client has been auto-installed
                if (information.Length == 6)
                    isAutoInstall = bool.Parse(information[5]);
            }));
        }
    }
}