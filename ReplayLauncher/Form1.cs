using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplayLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (var file in files)
            {
                if (System.IO.Path.GetExtension(file).Equals(".rofl", StringComparison.InvariantCultureIgnoreCase))
                {
                    //run the replay
                }
                else
                {
                    MessageBox.Show("This is no valid replay file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders\\");
            string mydocpath = (string)regKey.GetValue("Personal");
            ofd.InitialDirectory = mydocpath + @"\League of Legends\Replays";
            ofd.Filter = "League of Legends Replay file | *.rofl";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                replaypath.Text = ofd.FileName;
                checkvers();
                if (checkvers() == true)
                {
                    label1.Text = "Versions match";
                }
                if (checkvers() == false)
                {
                    label1.Text = "Versions do not match";
                }
            }
        }

        public bool checkvers()
        {
            //Reads version of the League of Legends.exe
            string fileName = @"C:\Riot Games\League of Legends\RADS\solutions\lol_game_client_sln\releases\0.0.1.157\deploy\League of Legends.exe";
            string gamevers = FileVersionInfo.GetVersionInfo(fileName).ProductVersion;
            //Reads the Replayfile          !! NOT WORKING 100% !!
            BinaryReader br = new BinaryReader(File.OpenRead(ofd.FileName));
            br.BaseStream.Position = 0x14A;
            char[] charArray = br.ReadChars(13);
            string repvers = new string(charArray);
            br.Close();
            return (string.Equals(gamevers.Substring(0, 4), repvers.Substring(0, 4)));            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

 
    }
}
