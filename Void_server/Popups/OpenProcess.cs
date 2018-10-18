using System;
using System.Windows.Forms;
using Void_server.Libs;

namespace Void_server.Popups
{
    public partial class OpenProcess : Form
    {
        public OpenProcess()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            RAT.Send($"process|{urlBox.Text}|{iterationsBox.Text}");
            this.Close();
        }

        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            Snake.Controls.Drag(e, this);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}