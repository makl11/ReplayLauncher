using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                if (System.IO.Path.GetExtension(file).Equals(".txt", StringComparison.InvariantCultureIgnoreCase))
                {
                    MessageBox.Show("This is a text file", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Not a text file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void button1_Click_1(object sender, EventArgs e)
        {
            ofd.Filter = "League of Legends Replay file | *.rofl";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                replaypath.Text = ofd.FileName;
            }
        }
    }
}
