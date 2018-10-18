//this control currently isn't being used since multiporting is not yet supported
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Void_server.Controls
{
    public class PortBox : Panel
    {
        //create variables
        Label port = new Label();
        Button setListening = new Button();

        public PortBox()
        {
            //set some properties
            this.BackColor = Color.DimGray;
            this.Size = new Size(161, 45);

            port.Location = new Point(11, 15);
            port.Font = new Font("Microsoft Sans Sherif", 10f, FontStyle.Regular);

            setListening.Size = new Size(75, 23);
            setListening.Location = new Point(76, 12);
            setListening.BackColor = Color.FromArgb(100, 100, 100);
            setListening.Click += SetListening_Click;
        }

        private void SetListening_Click(object sender, EventArgs e)
        {
            setListening.Text = setListening.Text == "not listening" ? "listening" : "not listening";

            //this is where it would do some stuff lol
        }
    }
}
