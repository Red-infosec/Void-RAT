using System;
using System.Windows.Forms;

namespace Void_server.Popups
{
    public partial class GatheringResultForm : Form
    {
        public GatheringResultForm(string resultToShow)
        {
            InitializeComponent();

            resultBox.Text = resultToShow;
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(resultBox.Text);
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
