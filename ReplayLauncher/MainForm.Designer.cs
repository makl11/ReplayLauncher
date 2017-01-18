namespace ReplayLauncher
{
    partial class MainForm
    {
    
       private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.replayPath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GameVersLabel = new System.Windows.Forms.Label();
            this.ReplayVersLabel = new System.Windows.Forms.Label();
            this.ReplayVersLabel2 = new System.Windows.Forms.Label();
            this.GameVersLabel2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playButton = new System.Windows.Forms.Button();
            this.instructions = new System.Windows.Forms.TextBox();
            this.cPlayingT = new System.Windows.Forms.Label();
            this.cPlayingC = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.browseButton);
            this.groupBox2.Controls.Add(this.replayPath);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Replay:";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(179, 22);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Choose";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // replayPath
            // 
            this.replayPath.Location = new System.Drawing.Point(7, 24);
            this.replayPath.Name = "replayPath";
            this.replayPath.ReadOnly = true;
            this.replayPath.Size = new System.Drawing.Size(166, 20);
            this.replayPath.TabIndex = 0;
            this.replayPath.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tableLayoutPanel1.Controls.Add(this.GameVersLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReplayVersLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ReplayVersLabel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.GameVersLabel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(63, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(191, 37);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GameVersLabel
            // 
            this.GameVersLabel.AutoSize = true;
            this.GameVersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameVersLabel.Location = new System.Drawing.Point(3, 0);
            this.GameVersLabel.Name = "GameVersLabel";
            this.GameVersLabel.Size = new System.Drawing.Size(84, 13);
            this.GameVersLabel.TabIndex = 0;
            this.GameVersLabel.Text = "Gameversion:";
            this.GameVersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReplayVersLabel
            // 
            this.ReplayVersLabel.AutoSize = true;
            this.ReplayVersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayVersLabel.Location = new System.Drawing.Point(3, 18);
            this.ReplayVersLabel.Name = "ReplayVersLabel";
            this.ReplayVersLabel.Size = new System.Drawing.Size(91, 13);
            this.ReplayVersLabel.TabIndex = 0;
            this.ReplayVersLabel.Text = "Replayversion:";
            this.ReplayVersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReplayVersLabel2
            // 
            this.ReplayVersLabel2.AutoSize = true;
            this.ReplayVersLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayVersLabel2.Location = new System.Drawing.Point(134, 18);
            this.ReplayVersLabel2.Name = "ReplayVersLabel2";
            this.ReplayVersLabel2.Size = new System.Drawing.Size(22, 13);
            this.ReplayVersLabel2.TabIndex = 0;
            this.ReplayVersLabel2.Text = "  -  ";
            this.ReplayVersLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameVersLabel2
            // 
            this.GameVersLabel2.AutoSize = true;
            this.GameVersLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameVersLabel2.Location = new System.Drawing.Point(134, 0);
            this.GameVersLabel2.Name = "GameVersLabel2";
            this.GameVersLabel2.Size = new System.Drawing.Size(22, 13);
            this.GameVersLabel2.TabIndex = 0;
            this.GameVersLabel2.Text = "  -  ";
            this.GameVersLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playButton);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = global::ReplayLauncher.Properties.Resources.play;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.Location = new System.Drawing.Point(7, 13);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(50, 50);
            this.playButton.TabIndex = 1;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // instructions
            // 
            this.instructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructions.Enabled = false;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.Location = new System.Drawing.Point(12, 76);
            this.instructions.Multiline = true;
            this.instructions.Name = "instructions";
            this.instructions.ReadOnly = true;
            this.instructions.Size = new System.Drawing.Size(260, 46);
            this.instructions.TabIndex = 0;
            this.instructions.Text = "Drag and Drop a League of Legends replay file (.rofl) file into the window or use" +
    " the browser below. Click the play button to start the replay.";
            // 
            // cPlayingT
            // 
            this.cPlayingT.AutoSize = true;
            this.cPlayingT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cPlayingT.Location = new System.Drawing.Point(75, 194);
            this.cPlayingT.Name = "cPlayingT";
            this.cPlayingT.Size = new System.Drawing.Size(133, 13);
            this.cPlayingT.TabIndex = 3;
            this.cPlayingT.Text = "Currently playing a replay...";
            this.cPlayingT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cPlayingT.Visible = false;
            // 
            // cPlayingC
            // 
            this.cPlayingC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cPlayingC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cPlayingC.Location = new System.Drawing.Point(-1, 191);
            this.cPlayingC.Name = "cPlayingC";
            this.cPlayingC.Size = new System.Drawing.Size(286, 21);
            this.cPlayingC.TabIndex = 4;
            this.cPlayingC.Visible = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.cPlayingT);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cPlayingC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "League of Legends Replay Launcher";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox replayPath;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label GameVersLabel;
        private System.Windows.Forms.Label ReplayVersLabel;
        private System.Windows.Forms.Label GameVersLabel2;
        private System.Windows.Forms.Label ReplayVersLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox instructions;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label cPlayingT;
        private System.Windows.Forms.Panel cPlayingC;
    }
}