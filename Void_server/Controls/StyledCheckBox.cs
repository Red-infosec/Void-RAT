using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Void_server.Controls
{
    [DefaultEvent("CheckChanged")] //sets the default event to CheckChanged so that when you double click on the event it'll be the 'CheckChanged' event
    public class StyledCheckBox : Panel
    {
        //create variables
        bool isChecked;
        Panel checkPanel = new Panel();
        private Color checkedColor = Color.FromArgb(1, 1, 1);
        private Color uncheckedColor = Color.FromArgb(110, 110, 110);

        public bool Checked
        {
            get { return isChecked; }
            set
            {
                //sets the value itself, sets the new background color, and raises the event if it isn't null
                isChecked = value;
                checkPanel.BackColor = value ? checkedColor : uncheckedColor;

                if (CheckChanged == null)
                    return;

                CheckEventArgs args = new CheckEventArgs(value);
                CheckChanged(this, args);
            }
        }

        public string optionalValue { get; set; }

        public event CheckedEvent CheckChanged;

        public StyledCheckBox()
        {
            //sets some properties
            this.Size = new Size(16, 16);
            this.BackColor = uncheckedColor;

            this.SizeChanged += StyledCheckBox_SizeChanged;

            checkPanel.Location = new Point(2, 2);
            checkPanel.BackColor = uncheckedColor;
            checkPanel.Click += CheckPanel_Click;
            SetCheckPanelSize();

            this.Controls.Add(checkPanel);
        }

        private void CheckPanel_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
        }

        private void StyledCheckBox_SizeChanged(object sender, EventArgs e)
        {
            SetCheckPanelSize();
        }

        private void SetCheckPanelSize()
        {
            checkPanel.Size = new Size(this.Width - 4, this.Height - 4);
        }

        public delegate void CheckedEvent(object sender, CheckEventArgs e);
    }

    public class CheckEventArgs
    {
        public bool Checked;

        public CheckEventArgs(bool isChecked)
        {
            Checked = isChecked;
        }
    }
}
