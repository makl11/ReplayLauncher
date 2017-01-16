using System;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace ReplayLauncher
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();

            this.version.Text = "Version: " + currentVersion();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=TVGWU49HXU2PG");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        public static string currentVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }
    }
}