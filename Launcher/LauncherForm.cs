using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Launcher
{
    public partial class LauncherForm : MetroForm
    {
        private readonly Redirector redirector;

        public LauncherForm()
        {
            InitializeComponent();

            var ipParts = Constants.SERVER_IP.Split('.');
            ip0Textbox.Text = ipParts[0];
            ip1Textbox.Text = ipParts[1];
            ip2Textbox.Text = ipParts[2];
            ip3Textbox.Text = ipParts[3];

            redirector = new Redirector();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            this.Hide();

            redirector.Start();
            RunMaplestory();
            redirector.End();

            this.Show();
        }

        private static void RunMaplestory()
        {
            Process.Start("Maplestory.exe", string.Format("GameLaunching {0} {1}", Constants.GMS_IP, 8484)).WaitForExit();
        }
    }
}
