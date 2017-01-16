namespace ReplayLauncher
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.donateButton = new System.Windows.Forms.PictureBox();
            this.version = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.donateButton)).BeginInit();
            this.SuspendLayout();
            // 
            // donateButton
            // 
            this.donateButton.Image = ((System.Drawing.Image)(resources.GetObject("donateButton.Image")));
            this.donateButton.Location = new System.Drawing.Point(79, 52);
            this.donateButton.Name = "donateButton";
            this.donateButton.Size = new System.Drawing.Size(122, 47);
            this.donateButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.donateButton.TabIndex = 0;
            this.donateButton.TabStop = false;
            this.donateButton.Click += new System.EventHandler(this.pictureBox1_Click);
            this.donateButton.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.donateButton.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // version
            // 
            this.version.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.version.Location = new System.Drawing.Point(76, 9);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(125, 16);
            this.version.TabIndex = 1;
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // author
            // 
            this.author.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.author.Location = new System.Drawing.Point(76, 29);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(125, 16);
            this.author.TabIndex = 2;
            this.author.Text = " by Max Klingelhoeffer";
            this.author.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.author);
            this.Controls.Add(this.version);
            this.Controls.Add(this.donateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.donateButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox donateButton;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label author;
    }
}