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
            label4.Text = gamevers().Substring(0, 4);
        }

        private string gamepath()
        {
            //Reads version of the League of Legends.exe
            RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Riot Games\League of Legends\"); //opens key
            string lolPath = (string)regKey.GetValue("Path");                                                             //reads key value
            string releasesPath = lolPath + @"RADS\solutions\lol_game_client_sln\releases\";                              //defines path to release folder
            string latestrelease = File.ReadLines(releasesPath + @"releaselisting_EUW").Last();                           //reads latest release number
            string loldeploy = releasesPath + latestrelease + @"\deploy\";                                                //defines location of latest release exe
            return loldeploy;
        }

        private string clientexe()
        {
            RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Riot Games\League of Legends\"); //opens key
            string lolPath = (string)regKey.GetValue("Path");
            return lolPath + "LeagueClient.exe";
        }

        public string gamevers()
        {
            string gamevers = FileVersionInfo.GetVersionInfo(gamepath() + "League of Legends.exe").ProductVersion;
            return (gamevers);

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (var file in files)
                {
                    if (System.IO.Path.GetExtension(file).Equals(".rofl", StringComparison.InvariantCultureIgnoreCase))
                    {
                        replaypath.Text = Path.GetFullPath(file);
                        replaypath.SelectionStart = replaypath.Text.Length;
                        replaypath.ScrollToCaret();
                        repvers();
                    }
                    else
                    {
                        MessageBox.Show("This is not a valid replay file!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void repsel()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders\\");
            string mydocpath = (string)regKey.GetValue("Personal");
            ofd.InitialDirectory = mydocpath + @"\League of Legends\Replays";
            ofd.Filter = "League of Legends Replay file | *.rofl";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                replaypath.Text = ofd.FileName;
                replaypath.SelectionStart = replaypath.Text.Length;
                replaypath.ScrollToCaret();
                repvers();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            repsel();
        }

        private string repname()
        {
            string rp = replaypath.Text;
            return rp;
        }

        private void repvers()
        {
            if (repname() != "")
            {
                //Reads the Replayfiles version      !! NOT WORKING 100% ACCURATE!!
                BinaryReader br = new BinaryReader(File.OpenRead(repname()));
                br.BaseStream.Position = 0x14A;
                char[] charArray = br.ReadChars(13);
                string replvers = new string(charArray);
                br.Close();
                label5.Text = replvers.Substring(0, 4);
            }
        }        

        public void runReplay()
            {
                if (repname() != "")
                {
                    if (string.Equals(label4.Text.Substring(0, 4), label5.Text.Substring(0, 4)))
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.WorkingDirectory = gamepath();
                        startInfo.FileName = "cmd.exe";
                        startInfo.Arguments = "/C cd " + "\"" + gamepath() + "\"" + " && " + "\"" + gamepath() + "League of Legends.exe" + "\" " + "\"" + clientexe() + "\" "
                            + "\"" + repname() + "\" " + "\"-UseRads\" ";
                        process.StartInfo = startInfo;
                        process.Start(); 
                    }
                    else
                    {
                        MessageBox.Show("The version of the replay does not\nmatch with the version of the game!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No valid replay file selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

        private void button2_Click(object sender, EventArgs e)
        {
            runReplay();
        }
    }
 }

