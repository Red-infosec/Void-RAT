namespace Void_server
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topBar = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.topBarLogo = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.homePanel = new System.Windows.Forms.Panel();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.buildPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.sBuildPanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.enAddJunk = new Void_server.Controls.StyledCheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.enAutoInstall = new Void_server.Controls.StyledCheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.portBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.build = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gBuildPanel = new System.Windows.Forms.Panel();
            this.v4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.v3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.v2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.v1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buildPathBox = new System.Windows.Forms.TextBox();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.clientsPanel = new System.Windows.Forms.Panel();
            this.clientBarOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdLogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.rATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdInstall = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdUninstall = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meatProc = new System.Windows.Forms.ToolStripMenuItem();
            this.pornProc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.customProc = new System.Windows.Forms.ToolStripMenuItem();
            this.informationGatheringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdGetBleu = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdCheckAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdAntivirus = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdShowMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdRCMD = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBar = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoSettings = new Void_server.Controls.MenuButton();
            this.gotoBuild = new Void_server.Controls.MenuButton();
            this.gotoClients = new Void_server.Controls.MenuButton();
            this.gotoHome = new Void_server.Controls.MenuButton();
            this.topBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topBarLogo)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.buildPanel.SuspendLayout();
            this.sBuildPanel.SuspendLayout();
            this.gBuildPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.clientBarOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.topBar.Controls.Add(this.statusLabel);
            this.topBar.Controls.Add(this.panel1);
            this.topBar.Controls.Add(this.topBarLogo);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(878, 42);
            this.topBar.TabIndex = 0;
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_handler);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(119, 15);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(84, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Starting server...";
            this.statusLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_handler);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Location = new System.Drawing.Point(818, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 29);
            this.panel1.TabIndex = 3;
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.Location = new System.Drawing.Point(3, 2);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(24, 24);
            this.minimize.TabIndex = 3;
            this.minimize.Text = "-";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(33, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(24, 24);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // topBarLogo
            // 
            this.topBarLogo.BackgroundImage = global::Void_server.Properties.Resources.void_topbar_logo;
            this.topBarLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.topBarLogo.Location = new System.Drawing.Point(-14, 1);
            this.topBarLogo.Name = "topBarLogo";
            this.topBarLogo.Size = new System.Drawing.Size(160, 40);
            this.topBarLogo.TabIndex = 1;
            this.topBarLogo.TabStop = false;
            this.topBarLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_handler);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.buildPanel);
            this.mainPanel.Controls.Add(this.settingsPanel);
            this.mainPanel.Controls.Add(this.clientsPanel);
            this.mainPanel.Controls.Add(this.homePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPanel.Location = new System.Drawing.Point(132, 42);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(746, 475);
            this.mainPanel.TabIndex = 1;
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.homePanel.Controls.Add(this.msgBox);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(746, 475);
            this.homePanel.TabIndex = 0;
            this.homePanel.Visible = false;
            // 
            // msgBox
            // 
            this.msgBox.BackColor = System.Drawing.Color.DimGray;
            this.msgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.msgBox.Location = new System.Drawing.Point(4, 4);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(738, 467);
            this.msgBox.TabIndex = 53;
            this.msgBox.Text = "0.0.0.0 (early alpha release) -\r\npretty much all fundemental RAT features, only s" +
    "tuff left for the beta release is adding more commands, multi-port support, and " +
    "better client obfuscation";
            // 
            // buildPanel
            // 
            this.buildPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buildPanel.Controls.Add(this.label4);
            this.buildPanel.Controls.Add(this.sBuildPanel);
            this.buildPanel.Controls.Add(this.build);
            this.buildPanel.Controls.Add(this.label3);
            this.buildPanel.Controls.Add(this.gBuildPanel);
            this.buildPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildPanel.Location = new System.Drawing.Point(0, 0);
            this.buildPanel.Name = "buildPanel";
            this.buildPanel.Size = new System.Drawing.Size(746, 475);
            this.buildPanel.TabIndex = 4;
            this.buildPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(2, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 67;
            this.label4.Text = "Settings";
            // 
            // sBuildPanel
            // 
            this.sBuildPanel.BackColor = System.Drawing.Color.DimGray;
            this.sBuildPanel.Controls.Add(this.label17);
            this.sBuildPanel.Controls.Add(this.enAddJunk);
            this.sBuildPanel.Controls.Add(this.label16);
            this.sBuildPanel.Controls.Add(this.enAutoInstall);
            this.sBuildPanel.Controls.Add(this.label12);
            this.sBuildPanel.Controls.Add(this.panel3);
            this.sBuildPanel.Controls.Add(this.portBox);
            this.sBuildPanel.Controls.Add(this.label10);
            this.sBuildPanel.Controls.Add(this.ipBox);
            this.sBuildPanel.Controls.Add(this.label5);
            this.sBuildPanel.Location = new System.Drawing.Point(5, 184);
            this.sBuildPanel.Name = "sBuildPanel";
            this.sBuildPanel.Size = new System.Drawing.Size(425, 143);
            this.sBuildPanel.TabIndex = 66;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(153, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 13);
            this.label17.TabIndex = 71;
            this.label17.Text = "Add junk (makes file bigger)";
            // 
            // enAddJunk
            // 
            this.enAddJunk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.enAddJunk.Checked = false;
            this.enAddJunk.Location = new System.Drawing.Point(134, 76);
            this.enAddJunk.Name = "enAddJunk";
            this.enAddJunk.optionalValue = null;
            this.enAddJunk.Size = new System.Drawing.Size(17, 17);
            this.enAddJunk.TabIndex = 70;
            this.enAddJunk.CheckChanged += new Void_server.Controls.StyledCheckBox.CheckedEvent(this.enAddJunk_CheckChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "Auto install on launch";
            // 
            // enAutoInstall
            // 
            this.enAutoInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.enAutoInstall.Checked = true;
            this.enAutoInstall.Location = new System.Drawing.Point(6, 76);
            this.enAutoInstall.Name = "enAutoInstall";
            this.enAutoInstall.optionalValue = null;
            this.enAutoInstall.Size = new System.Drawing.Size(17, 17);
            this.enAutoInstall.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(180, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 67;
            this.label12.Text = "Additions";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.panel3.Location = new System.Drawing.Point(6, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 4);
            this.panel3.TabIndex = 66;
            // 
            // portBox
            // 
            this.portBox.BackColor = System.Drawing.Color.DimGray;
            this.portBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.portBox.Location = new System.Drawing.Point(204, 24);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(215, 21);
            this.portBox.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(4, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 62;
            this.label10.Text = "IP address";
            // 
            // ipBox
            // 
            this.ipBox.BackColor = System.Drawing.Color.DimGray;
            this.ipBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ipBox.Location = new System.Drawing.Point(6, 24);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(193, 21);
            this.ipBox.TabIndex = 63;
            this.ipBox.Text = "0.0.0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(202, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "Port";
            // 
            // build
            // 
            this.build.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.build.FlatAppearance.BorderSize = 0;
            this.build.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.build.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.build.Location = new System.Drawing.Point(640, 425);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(100, 44);
            this.build.TabIndex = 56;
            this.build.Text = "Build";
            this.build.UseVisualStyleBackColor = false;
            this.build.Click += new System.EventHandler(this.build_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(2, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Building options";
            // 
            // gBuildPanel
            // 
            this.gBuildPanel.BackColor = System.Drawing.Color.DimGray;
            this.gBuildPanel.Controls.Add(this.v4);
            this.gBuildPanel.Controls.Add(this.label15);
            this.gBuildPanel.Controls.Add(this.v3);
            this.gBuildPanel.Controls.Add(this.label14);
            this.gBuildPanel.Controls.Add(this.v2);
            this.gBuildPanel.Controls.Add(this.label13);
            this.gBuildPanel.Controls.Add(this.comBox);
            this.gBuildPanel.Controls.Add(this.label8);
            this.gBuildPanel.Controls.Add(this.v1);
            this.gBuildPanel.Controls.Add(this.label9);
            this.gBuildPanel.Controls.Add(this.descBox);
            this.gBuildPanel.Controls.Add(this.label7);
            this.gBuildPanel.Controls.Add(this.nameBox);
            this.gBuildPanel.Controls.Add(this.label6);
            this.gBuildPanel.Controls.Add(this.label11);
            this.gBuildPanel.Controls.Add(this.panel4);
            this.gBuildPanel.Controls.Add(this.browse);
            this.gBuildPanel.Controls.Add(this.label2);
            this.gBuildPanel.Controls.Add(this.buildPathBox);
            this.gBuildPanel.Location = new System.Drawing.Point(5, 21);
            this.gBuildPanel.Name = "gBuildPanel";
            this.gBuildPanel.Size = new System.Drawing.Size(425, 143);
            this.gBuildPanel.TabIndex = 42;
            // 
            // v4
            // 
            this.v4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.v4.BackColor = System.Drawing.Color.DimGray;
            this.v4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.v4.Location = new System.Drawing.Point(95, 116);
            this.v4.Name = "v4";
            this.v4.Size = new System.Drawing.Size(18, 21);
            this.v4.TabIndex = 55;
            this.v4.Text = "0";
            this.v4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label15.Location = new System.Drawing.Point(84, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 16);
            this.label15.TabIndex = 54;
            this.label15.Text = ".";
            // 
            // v3
            // 
            this.v3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.v3.BackColor = System.Drawing.Color.DimGray;
            this.v3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.v3.Location = new System.Drawing.Point(65, 116);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(18, 21);
            this.v3.TabIndex = 53;
            this.v3.Text = "0";
            this.v3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label14.Location = new System.Drawing.Point(54, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 16);
            this.label14.TabIndex = 52;
            this.label14.Text = ".";
            // 
            // v2
            // 
            this.v2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.v2.BackColor = System.Drawing.Color.DimGray;
            this.v2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.v2.Location = new System.Drawing.Point(35, 116);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(18, 21);
            this.v2.TabIndex = 51;
            this.v2.Text = "0";
            this.v2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label13.Location = new System.Drawing.Point(24, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 16);
            this.label13.TabIndex = 50;
            this.label13.Text = ".";
            // 
            // comBox
            // 
            this.comBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comBox.BackColor = System.Drawing.Color.DimGray;
            this.comBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comBox.Location = new System.Drawing.Point(119, 116);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(300, 21);
            this.comBox.TabIndex = 49;
            this.comBox.Text = "iLinked Software";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(116, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Company";
            // 
            // v1
            // 
            this.v1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.v1.BackColor = System.Drawing.Color.DimGray;
            this.v1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.v1.Location = new System.Drawing.Point(6, 115);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(18, 21);
            this.v1.TabIndex = 47;
            this.v1.Text = "1";
            this.v1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(5, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Version";
            // 
            // descBox
            // 
            this.descBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.descBox.BackColor = System.Drawing.Color.DimGray;
            this.descBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.descBox.Location = new System.Drawing.Point(204, 75);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(215, 21);
            this.descBox.TabIndex = 45;
            this.descBox.Text = "An easy to use RAT";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(202, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "File description";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameBox.BackColor = System.Drawing.Color.DimGray;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nameBox.Location = new System.Drawing.Point(6, 75);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(193, 21);
            this.nameBox.TabIndex = 43;
            this.nameBox.Text = "Void client";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(4, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Product name";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(178, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Assembly";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.panel4.Location = new System.Drawing.Point(6, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(413, 4);
            this.panel4.TabIndex = 20;
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.browse.FlatAppearance.BorderSize = 0;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Location = new System.Drawing.Point(357, 6);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(62, 22);
            this.browse.TabIndex = 9;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Build path:";
            // 
            // buildPathBox
            // 
            this.buildPathBox.BackColor = System.Drawing.Color.DimGray;
            this.buildPathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buildPathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildPathBox.Location = new System.Drawing.Point(60, 6);
            this.buildPathBox.Name = "buildPathBox";
            this.buildPathBox.Size = new System.Drawing.Size(291, 22);
            this.buildPathBox.TabIndex = 7;
            this.buildPathBox.Text = "C:\\client.exe";
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(746, 475);
            this.settingsPanel.TabIndex = 5;
            this.settingsPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nothing here yet";
            // 
            // clientsPanel
            // 
            this.clientsPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.clientsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsPanel.Location = new System.Drawing.Point(0, 0);
            this.clientsPanel.Name = "clientsPanel";
            this.clientsPanel.Size = new System.Drawing.Size(746, 475);
            this.clientsPanel.TabIndex = 1;
            this.clientsPanel.Visible = false;
            // 
            // clientBarOptions
            // 
            this.clientBarOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.rATToolStripMenuItem,
            this.processToolStripMenuItem,
            this.informationGatheringToolStripMenuItem,
            this.filesToolStripMenuItem,
            this.removeBar});
            this.clientBarOptions.Name = "clientBarOptions";
            this.clientBarOptions.Size = new System.Drawing.Size(192, 158);
            this.clientBarOptions.Opening += new System.ComponentModel.CancelEventHandler(this.clientBarOptions_Opening);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdShutdown,
            this.cmdRestart,
            this.cmdLogOff});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // cmdShutdown
            // 
            this.cmdShutdown.Name = "cmdShutdown";
            this.cmdShutdown.Size = new System.Drawing.Size(128, 22);
            this.cmdShutdown.Text = "Shutdown";
            this.cmdShutdown.Click += new System.EventHandler(this.cmdShutdown_Click);
            // 
            // cmdRestart
            // 
            this.cmdRestart.Name = "cmdRestart";
            this.cmdRestart.Size = new System.Drawing.Size(128, 22);
            this.cmdRestart.Text = "Restart";
            // 
            // cmdLogOff
            // 
            this.cmdLogOff.Name = "cmdLogOff";
            this.cmdLogOff.Size = new System.Drawing.Size(128, 22);
            this.cmdLogOff.Text = "Log off";
            this.cmdLogOff.Click += new System.EventHandler(this.cmdLogOff_Click);
            // 
            // rATToolStripMenuItem
            // 
            this.rATToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdInstall,
            this.cmdUninstall});
            this.rATToolStripMenuItem.Name = "rATToolStripMenuItem";
            this.rATToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.rATToolStripMenuItem.Text = "RAT";
            // 
            // cmdInstall
            // 
            this.cmdInstall.Name = "cmdInstall";
            this.cmdInstall.Size = new System.Drawing.Size(120, 22);
            this.cmdInstall.Text = "Install";
            this.cmdInstall.Click += new System.EventHandler(this.cmdInstall_Click);
            // 
            // cmdUninstall
            // 
            this.cmdUninstall.Name = "cmdUninstall";
            this.cmdUninstall.Size = new System.Drawing.Size(120, 22);
            this.cmdUninstall.Text = "Uninstall";
            this.cmdUninstall.Click += new System.EventHandler(this.cmdUninstall_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meatProc,
            this.pornProc,
            this.toolStripSeparator1,
            this.customProc});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // meatProc
            // 
            this.meatProc.Name = "meatProc";
            this.meatProc.Size = new System.Drawing.Size(123, 22);
            this.meatProc.Text = "Meatspin";
            this.meatProc.Click += new System.EventHandler(this.meatProc_Click);
            // 
            // pornProc
            // 
            this.pornProc.Name = "pornProc";
            this.pornProc.Size = new System.Drawing.Size(123, 22);
            this.pornProc.Text = "PornHub";
            this.pornProc.Click += new System.EventHandler(this.pornProc_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // customProc
            // 
            this.customProc.Name = "customProc";
            this.customProc.Size = new System.Drawing.Size(123, 22);
            this.customProc.Text = "Custom";
            this.customProc.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // informationGatheringToolStripMenuItem
            // 
            this.informationGatheringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getCredentialsToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.informationGatheringToolStripMenuItem.Name = "informationGatheringToolStripMenuItem";
            this.informationGatheringToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.informationGatheringToolStripMenuItem.Text = "Information gathering";
            // 
            // getCredentialsToolStripMenuItem
            // 
            this.getCredentialsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdGetBleu});
            this.getCredentialsToolStripMenuItem.Name = "getCredentialsToolStripMenuItem";
            this.getCredentialsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.getCredentialsToolStripMenuItem.Text = "Credentials";
            // 
            // cmdGetBleu
            // 
            this.cmdGetBleu.Name = "cmdGetBleu";
            this.cmdGetBleu.Size = new System.Drawing.Size(179, 22);
            this.cmdGetBleu.Text = "Bleu (roblox exploit)";
            this.cmdGetBleu.Click += new System.EventHandler(this.cmdGetBleu_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdCheckAdmin,
            this.cmdAntivirus});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // cmdCheckAdmin
            // 
            this.cmdCheckAdmin.Name = "cmdCheckAdmin";
            this.cmdCheckAdmin.Size = new System.Drawing.Size(177, 22);
            this.cmdCheckAdmin.Text = "Check admin rights";
            this.cmdCheckAdmin.Click += new System.EventHandler(this.cmdCheckAdmin_Click);
            // 
            // cmdAntivirus
            // 
            this.cmdAntivirus.Name = "cmdAntivirus";
            this.cmdAntivirus.Size = new System.Drawing.Size(177, 22);
            this.cmdAntivirus.Text = "Antivirus";
            this.cmdAntivirus.Click += new System.EventHandler(this.cmdAntivirus_Click);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdShowMsg,
            this.cmdRCMD});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.filesToolStripMenuItem.Text = "Misc";
            // 
            // cmdShowMsg
            // 
            this.cmdShowMsg.Name = "cmdShowMsg";
            this.cmdShowMsg.Size = new System.Drawing.Size(206, 22);
            this.cmdShowMsg.Text = "Messagebox";
            this.cmdShowMsg.Click += new System.EventHandler(this.cmdShowMsg_Click);
            // 
            // cmdRCMD
            // 
            this.cmdRCMD.Name = "cmdRCMD";
            this.cmdRCMD.Size = new System.Drawing.Size(206, 22);
            this.cmdRCMD.Text = "Remote CMD (beta)";
            this.cmdRCMD.Click += new System.EventHandler(this.cmdRCMD_Click);
            // 
            // removeBar
            // 
            this.removeBar.Name = "removeBar";
            this.removeBar.Size = new System.Drawing.Size(191, 22);
            this.removeBar.Text = "Remove";
            this.removeBar.Click += new System.EventHandler(this.removeBar_Click);
            // 
            // gotoSettings
            // 
            this.gotoSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.gotoSettings.FlatAppearance.BorderSize = 0;
            this.gotoSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.gotoSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.gotoSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotoSettings.linkedPanel = this.settingsPanel;
            this.gotoSettings.Location = new System.Drawing.Point(4, 170);
            this.gotoSettings.Name = "gotoSettings";
            this.gotoSettings.Size = new System.Drawing.Size(123, 36);
            this.gotoSettings.TabIndex = 6;
            this.gotoSettings.Text = "Settings";
            this.gotoSettings.UseVisualStyleBackColor = false;
            // 
            // gotoBuild
            // 
            this.gotoBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.gotoBuild.FlatAppearance.BorderSize = 0;
            this.gotoBuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.gotoBuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.gotoBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotoBuild.linkedPanel = this.buildPanel;
            this.gotoBuild.Location = new System.Drawing.Point(4, 128);
            this.gotoBuild.Name = "gotoBuild";
            this.gotoBuild.Size = new System.Drawing.Size(123, 36);
            this.gotoBuild.TabIndex = 5;
            this.gotoBuild.Text = "Build client";
            this.gotoBuild.UseVisualStyleBackColor = false;
            // 
            // gotoClients
            // 
            this.gotoClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.gotoClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gotoClients.FlatAppearance.BorderSize = 0;
            this.gotoClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.gotoClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.gotoClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotoClients.linkedPanel = this.clientsPanel;
            this.gotoClients.Location = new System.Drawing.Point(4, 87);
            this.gotoClients.Name = "gotoClients";
            this.gotoClients.Size = new System.Drawing.Size(123, 36);
            this.gotoClients.TabIndex = 2;
            this.gotoClients.Text = "Clients";
            this.gotoClients.UseVisualStyleBackColor = false;
            // 
            // gotoHome
            // 
            this.gotoHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.gotoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gotoHome.FlatAppearance.BorderSize = 0;
            this.gotoHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.gotoHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.gotoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotoHome.linkedPanel = this.homePanel;
            this.gotoHome.Location = new System.Drawing.Point(4, 46);
            this.gotoHome.Name = "gotoHome";
            this.gotoHome.Size = new System.Drawing.Size(123, 36);
            this.gotoHome.TabIndex = 0;
            this.gotoHome.Text = "Home";
            this.gotoHome.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(878, 517);
            this.Controls.Add(this.gotoSettings);
            this.Controls.Add(this.gotoBuild);
            this.Controls.Add(this.gotoClients);
            this.Controls.Add(this.gotoHome);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Void";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topBarLogo)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.buildPanel.ResumeLayout(false);
            this.buildPanel.PerformLayout();
            this.sBuildPanel.ResumeLayout(false);
            this.sBuildPanel.PerformLayout();
            this.gBuildPanel.ResumeLayout(false);
            this.gBuildPanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.clientBarOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.PictureBox topBarLogo;
        private System.Windows.Forms.Panel mainPanel;
        private Controls.MenuButton gotoHome;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimize;
        private Controls.MenuButton gotoClients;
        private System.Windows.Forms.Panel clientsPanel;
        private System.Windows.Forms.Panel buildPanel;
        private Controls.MenuButton gotoBuild;
        private System.Windows.Forms.Panel gBuildPanel;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox buildPathBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox v4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox v3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox v2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox comBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox v1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button build;
        private System.Windows.Forms.ContextMenuStrip clientBarOptions;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdShutdown;
        private System.Windows.Forms.ToolStripMenuItem cmdRestart;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customProc;
        private System.Windows.Forms.ToolStripMenuItem meatProc;
        private System.Windows.Forms.ToolStripMenuItem pornProc;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ToolStripMenuItem removeBar;
        private System.Windows.Forms.Panel settingsPanel;
        private Controls.MenuButton gotoSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.ToolStripMenuItem cmdLogOff;
        private System.Windows.Forms.ToolStripMenuItem informationGatheringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCredentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdGetBleu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel sBuildPanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdShowMsg;
        private System.Windows.Forms.ToolStripMenuItem cmdRCMD;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdCheckAdmin;
        private System.Windows.Forms.ToolStripMenuItem rATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdUninstall;
        private System.Windows.Forms.Label label16;
        private Controls.StyledCheckBox enAutoInstall;
        private System.Windows.Forms.ToolStripMenuItem cmdInstall;
        private System.Windows.Forms.Label label17;
        private Controls.StyledCheckBox enAddJunk;
        private System.Windows.Forms.ToolStripMenuItem cmdAntivirus;
    }
}

