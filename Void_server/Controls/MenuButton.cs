using System;
using System.Drawing;
using System.Windows.Forms;
using Void_server.Libs;

namespace Void_server.Controls
{
    public class MenuButton : Button
    {
        //creates variables
        private Panel privPanel;
        private Color norCol = Color.FromArgb(39, 60, 117);
        public Color selCol = Color.FromArgb(25, 42, 86);

        //properties
        public Panel linkedPanel
        {
            get { return privPanel; }
            set
            {
                //sets the value and sets the 'VisibleChanged' property to ours
                privPanel = value;

                privPanel.VisibleChanged += panelVisChanged;
            }
        }

        //constructor
        public MenuButton()
        {
            //set button properties
            this.Text = "unnamed";
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.DimGray;
            this.Size = new Size(92, 36);
            this.FlatAppearance.MouseDownBackColor = this.BackColor;
            this.FlatAppearance.MouseOverBackColor = this.BackColor;
            this.FlatAppearance.BorderSize = 0;
            this.Click += MenuButton_Click;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            //make the panel visible
            privPanel.Visible = true;

            //deselect all other panels (just to make sure there won't be 10 fucking tabs open at once)
            Pages.Deselect(privPanel);
        }

        private void panelVisChanged(object sender, EventArgs e)
        {
            //set button properies appropriatly
            this.BackColor = privPanel.Visible ? selCol : norCol;
            this.FlatAppearance.MouseDownBackColor = this.BackColor;
            this.FlatAppearance.MouseOverBackColor = this.BackColor;
        }
    }
}