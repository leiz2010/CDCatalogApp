namespace CDCatalogWinFormsApp
{
    partial class SearchForm
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBarLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.AlbumListBox = new System.Windows.Forms.ListBox();
            this.SongListBox = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.albumListLabel = new System.Windows.Forms.Label();
            this.songListLabel = new System.Windows.Forms.Label();
            this.searchDetailLabel = new System.Windows.Forms.Label();
            this.showAblumDetialButton = new System.Windows.Forms.Button();
            this.showSongDetailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(52, 54);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(308, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // searchBarLabel
            // 
            this.searchBarLabel.AutoSize = true;
            this.searchBarLabel.Location = new System.Drawing.Point(49, 24);
            this.searchBarLabel.Name = "searchBarLabel";
            this.searchBarLabel.Size = new System.Drawing.Size(0, 13);
            this.searchBarLabel.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(382, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 29);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // AlbumListBox
            // 
            this.AlbumListBox.FormattingEnabled = true;
            this.AlbumListBox.Location = new System.Drawing.Point(52, 157);
            this.AlbumListBox.Name = "AlbumListBox";
            this.AlbumListBox.Size = new System.Drawing.Size(200, 238);
            this.AlbumListBox.TabIndex = 3;
            // 
            // SongListBox
            // 
            this.SongListBox.FormattingEnabled = true;
            this.SongListBox.Location = new System.Drawing.Point(280, 155);
            this.SongListBox.Name = "SongListBox";
            this.SongListBox.Size = new System.Drawing.Size(200, 238);
            this.SongListBox.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(213, 476);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 27);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // albumListLabel
            // 
            this.albumListLabel.AutoSize = true;
            this.albumListLabel.Location = new System.Drawing.Point(49, 132);
            this.albumListLabel.Name = "albumListLabel";
            this.albumListLabel.Size = new System.Drawing.Size(36, 13);
            this.albumListLabel.TabIndex = 6;
            this.albumListLabel.Text = "Album";
            // 
            // songListLabel
            // 
            this.songListLabel.AutoSize = true;
            this.songListLabel.Location = new System.Drawing.Point(278, 132);
            this.songListLabel.Name = "songListLabel";
            this.songListLabel.Size = new System.Drawing.Size(32, 13);
            this.songListLabel.TabIndex = 7;
            this.songListLabel.Text = "Song";
            // 
            // searchDetailLabel
            // 
            this.searchDetailLabel.AutoSize = true;
            this.searchDetailLabel.Location = new System.Drawing.Point(50, 97);
            this.searchDetailLabel.Name = "searchDetailLabel";
            this.searchDetailLabel.Size = new System.Drawing.Size(196, 13);
            this.searchDetailLabel.TabIndex = 8;
            this.searchDetailLabel.Text = "Select a search result to see item details";
            // 
            // showAblumDetialButton
            // 
            this.showAblumDetialButton.Location = new System.Drawing.Point(53, 412);
            this.showAblumDetialButton.Name = "showAblumDetialButton";
            this.showAblumDetialButton.Size = new System.Drawing.Size(199, 27);
            this.showAblumDetialButton.TabIndex = 9;
            this.showAblumDetialButton.Text = "Album Detail";
            this.showAblumDetialButton.UseVisualStyleBackColor = true;
            this.showAblumDetialButton.Click += new System.EventHandler(this.showAblumDetialButton_Click);
            // 
            // showSongDetailButton
            // 
            this.showSongDetailButton.Location = new System.Drawing.Point(280, 412);
            this.showSongDetailButton.Name = "showSongDetailButton";
            this.showSongDetailButton.Size = new System.Drawing.Size(200, 26);
            this.showSongDetailButton.TabIndex = 10;
            this.showSongDetailButton.Text = "Song Detail";
            this.showSongDetailButton.UseVisualStyleBackColor = true;
            this.showSongDetailButton.Click += new System.EventHandler(this.showSongDetailButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 540);
            this.Controls.Add(this.showSongDetailButton);
            this.Controls.Add(this.showAblumDetialButton);
            this.Controls.Add(this.searchDetailLabel);
            this.Controls.Add(this.songListLabel);
            this.Controls.Add(this.albumListLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SongListBox);
            this.Controls.Add(this.AlbumListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBarLabel);
            this.Controls.Add(this.searchTextBox);
            this.Name = "SearchForm";
            this.Text = "Search by Title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchBarLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox AlbumListBox;
        private System.Windows.Forms.ListBox SongListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label albumListLabel;
        private System.Windows.Forms.Label songListLabel;
        private System.Windows.Forms.Label searchDetailLabel;
        private System.Windows.Forms.Button showAblumDetialButton;
        private System.Windows.Forms.Button showSongDetailButton;
    }
}