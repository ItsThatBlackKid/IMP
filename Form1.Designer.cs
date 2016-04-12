namespace Imagine_Music_Player
{
    partial class musicForm
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
            this.libraryPanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.albumBox = new System.Windows.Forms.PictureBox();
            this.songProgress = new System.Windows.Forms.ProgressBar();
            this.songName = new System.Windows.Forms.Label();
            this.shuffleBox = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.libraryView = new System.Windows.Forms.Panel();
            this.fileList = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.albumColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.artistColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressUpdate = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBox)).BeginInit();
            this.libraryView.SuspendLayout();
            this.SuspendLayout();
            // 
            // libraryPanel
            // 
            this.libraryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.libraryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.libraryPanel.Location = new System.Drawing.Point(0, 31);
            this.libraryPanel.Name = "libraryPanel";
            this.libraryPanel.Size = new System.Drawing.Size(261, 467);
            this.libraryPanel.TabIndex = 2;
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.albumBox);
            this.infoPanel.Controls.Add(this.songProgress);
            this.infoPanel.Controls.Add(this.songName);
            this.infoPanel.Controls.Add(this.shuffleBox);
            this.infoPanel.Controls.Add(this.button3);
            this.infoPanel.Controls.Add(this.button2);
            this.infoPanel.Controls.Add(this.playButton);
            this.infoPanel.Location = new System.Drawing.Point(0, 498);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1181, 85);
            this.infoPanel.TabIndex = 0;
            // 
            // albumBox
            // 
            this.albumBox.Location = new System.Drawing.Point(980, 5);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(140, 69);
            this.albumBox.TabIndex = 7;
            this.albumBox.TabStop = false;
            // 
            // songProgress
            // 
            this.songProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.songProgress.Location = new System.Drawing.Point(356, 41);
            this.songProgress.Name = "songProgress";
            this.songProgress.Size = new System.Drawing.Size(494, 10);
            this.songProgress.TabIndex = 6;
            // 
            // songName
            // 
            this.songName.AutoEllipsis = true;
            this.songName.AutoSize = true;
            this.songName.Location = new System.Drawing.Point(568, 57);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(138, 17);
            this.songName.TabIndex = 5;
            this.songName.Text = "Welcome to Imagine!";
            // 
            // shuffleBox
            // 
            this.shuffleBox.AutoSize = true;
            this.shuffleBox.Location = new System.Drawing.Point(376, 14);
            this.shuffleBox.Name = "shuffleBox";
            this.shuffleBox.Size = new System.Drawing.Size(74, 21);
            this.shuffleBox.TabIndex = 4;
            this.shuffleBox.Text = "Shuffle";
            this.shuffleBox.UseVisualStyleBackColor = true;
            this.shuffleBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(11, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(226, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Location = new System.Drawing.Point(114, 19);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 52);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.play_click);
            // 
            // libraryView
            // 
            this.libraryView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.libraryView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.libraryView.Controls.Add(this.fileList);
            this.libraryView.Location = new System.Drawing.Point(261, 31);
            this.libraryView.Name = "libraryView";
            this.libraryView.Size = new System.Drawing.Size(917, 467);
            this.libraryView.TabIndex = 3;
            // 
            // fileList
            // 
            this.fileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.albumColumn,
            this.artistColumn,
            this.fLocal});
            this.fileList.GridLines = true;
            this.fileList.Location = new System.Drawing.Point(-1, -1);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(917, 467);
            this.fileList.TabIndex = 0;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.View = System.Windows.Forms.View.Details;
            this.fileList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.show_info);
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged_1);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 173;
            // 
            // albumColumn
            // 
            this.albumColumn.Text = "Album";
            this.albumColumn.Width = 103;
            // 
            // artistColumn
            // 
            this.artistColumn.Text = "Artist";
            this.artistColumn.Width = 85;
            // 
            // fLocal
            // 
            this.fLocal.Text = "File Location";
            this.fLocal.Width = 105;
            // 
            // progressUpdate
            // 
            this.progressUpdate.Interval = 1000;
            this.progressUpdate.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 33);
            this.panel1.TabIndex = 1;
            // 
            // musicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.libraryView);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.libraryPanel);
            this.Name = "musicForm";
            this.Text = "Imagine Music Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.close_all_processes);
            this.Load += new System.EventHandler(this.musicForm_Load);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBox)).EndInit();
            this.libraryView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel libraryPanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel libraryView;
        private System.Windows.Forms.ListView fileList;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader albumColumn;
        private System.Windows.Forms.ColumnHeader artistColumn;
        private System.Windows.Forms.ColumnHeader fLocal;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox shuffleBox;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.ProgressBar songProgress;
        private System.Windows.Forms.Timer progressUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox albumBox;

    }
}

