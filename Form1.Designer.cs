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
            this.libraryPanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.libraryView = new System.Windows.Forms.Panel();
            this.fileList = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.albumColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.artistColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.infoPanel.SuspendLayout();
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
            this.infoPanel.Controls.Add(this.button3);
            this.infoPanel.Controls.Add(this.button2);
            this.infoPanel.Controls.Add(this.playButton);
            this.infoPanel.Location = new System.Drawing.Point(0, 498);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1181, 85);
            this.infoPanel.TabIndex = 0;
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
            this.fileList.Location = new System.Drawing.Point(-1, -1);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(917, 467);
            this.fileList.TabIndex = 0;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.View = System.Windows.Forms.View.Details;
            this.fileList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.show_info);
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
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Location = new System.Drawing.Point(561, 9);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 66);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.play_click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(664, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(442, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // musicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 582);
            this.Controls.Add(this.libraryView);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.libraryPanel);
            this.Name = "musicForm";
            this.Text = "Imagine Music Player";
            this.infoPanel.ResumeLayout(false);
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

    }
}

