using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Void_server.Popups
{
    public partial class DefaultInputForm : Form
    {
        public List<string> results = new List<string>();
        private List<TextBox> inputBoxes = new List<TextBox>();

        public DefaultInputForm(string text, params string[] collection)
        {
            InitializeComponent();

            titleLabel.Text = text;
            
            inputBoxes.Add(resultBox);

            resultBox.Text = collection[0];

            for (int i = 1; i < collection.Length; i++)
            {
                if (inputBoxes.Count > i)
                    inputBoxes[i].Text = collection[i];
                else
                    AddInputBox(collection[i]);
            }
        }

        private void apply_Click(object sender, EventArgs e)
        {
            foreach (var box in inputBoxes)
                results.Add(box.Text);
            this.Hide();
        }

        private void AddInputBox(string defaultText, bool addOptionalButton = false, EventHandler action = null)
        {
            TextBox box = GetInputBox();

            box.Left = 5;
            box.Top = inputBoxes[inputBoxes.Count - 1].Top + 27;

            this.Controls.Add(box);

            this.Height += 27;

            inputBoxes.Add(box);
        }

        private TextBox GetInputBox()
        {
            TextBox box = new TextBox();
            box.BackColor = Color.DimGray;
            box.Font = new Font("Microsoft Sans Sherif", 9f, FontStyle.Regular);
            box.Size = new Size(194, 21);
            box.BorderStyle = BorderStyle.FixedSingle;

            return box;
        }
    }
}
