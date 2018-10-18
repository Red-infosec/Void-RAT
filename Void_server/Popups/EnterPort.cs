using System;
using System.Windows.Forms;
using Void_server.Libs;

namespace Void_server.Popups
{
    public partial class EnterPort : Form
    {
        public EnterPort()
        {
            InitializeComponent();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            //if unable to convert
            if (!Checking.CheckConvertInt(portBox.Text)) 
            {
                //show error
                MessageBox.Show("Please enter a valid port", "error");
                return;
            }

            //create a new instance of the MainForm class and put in the port
            MainForm main = new MainForm(int.Parse(portBox.Text));
            main.Show();
            this.Hide();
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