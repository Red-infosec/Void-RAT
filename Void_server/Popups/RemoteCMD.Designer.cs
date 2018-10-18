namespace Void_server.Popups
{
    partial class RemoteCMD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteCMD));
            this.cmdInputBox = new System.Windows.Forms.TextBox();
            this.cmdBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmdInputBox
            // 
            this.cmdInputBox.BackColor = System.Drawing.Color.Gray;
            this.cmdInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdInputBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInputBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmdInputBox.Location = new System.Drawing.Point(0, 382);
            this.cmdInputBox.Name = "cmdInputBox";
            this.cmdInputBox.Size = new System.Drawing.Size(647, 29);
            this.cmdInputBox.TabIndex = 67;
            this.cmdInputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdInputBox_KeyDown);
            // 
            // cmdBox
            // 
            this.cmdBox.BackColor = System.Drawing.Color.DimGray;
            this.cmdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmdBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdBox.Location = new System.Drawing.Point(0, 0);
            this.cmdBox.Name = "cmdBox";
            this.cmdBox.Size = new System.Drawing.Size(647, 382);
            this.cmdBox.TabIndex = 68;
            this.cmdBox.Text = "";
            // 
            // RemoteCMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 411);
            this.Controls.Add(this.cmdBox);
            this.Controls.Add(this.cmdInputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoteCMD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote CMD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoteCMD_FormClosing);
            this.Load += new System.EventHandler(this.RemoteCMD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cmdInputBox;
        private System.Windows.Forms.RichTextBox cmdBox;
    }
}