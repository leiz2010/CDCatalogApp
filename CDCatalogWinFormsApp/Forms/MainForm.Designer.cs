namespace CDCatalogWinFormsApp
{
    partial class MainForm
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
            this.addSongButton = new System.Windows.Forms.Button();
            this.addAlbumButton = new System.Windows.Forms.Button();
            this.rateAlbumSongButton = new System.Windows.Forms.Button();
            this.searchTitleButton = new System.Windows.Forms.Button();
            this.searchGenreButton = new System.Windows.Forms.Button();
            this.searchArtistButton = new System.Windows.Forms.Button();
            this.songDataGridView = new System.Windows.Forms.DataGridView();
            this.albumDataGridView = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.albumLabel = new System.Windows.Forms.Label();
            this.songsLabel = new System.Windows.Forms.Label();
            this.playListButton = new System.Windows.Forms.Button();
            this.allSongButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addSongButton
            // 
            this.addSongButton.Location = new System.Drawing.Point(992, 66);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(140, 35);
            this.addSongButton.TabIndex = 0;
            this.addSongButton.Text = "Add Song";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // addAlbumButton
            // 
            this.addAlbumButton.Location = new System.Drawing.Point(993, 107);
            this.addAlbumButton.Name = "addAlbumButton";
            this.addAlbumButton.Size = new System.Drawing.Size(140, 35);
            this.addAlbumButton.TabIndex = 1;
            this.addAlbumButton.Text = "Add Album";
            this.addAlbumButton.UseVisualStyleBackColor = true;
            this.addAlbumButton.Click += new System.EventHandler(this.addAlbumButton_Click);
            // 
            // rateAlbumSongButton
            // 
            this.rateAlbumSongButton.Location = new System.Drawing.Point(993, 148);
            this.rateAlbumSongButton.Name = "rateAlbumSongButton";
            this.rateAlbumSongButton.Size = new System.Drawing.Size(140, 35);
            this.rateAlbumSongButton.TabIndex = 2;
            this.rateAlbumSongButton.Text = "Rate";
            this.rateAlbumSongButton.UseVisualStyleBackColor = true;
            this.rateAlbumSongButton.Click += new System.EventHandler(this.rateAlbumSongButton_Click);
            // 
            // searchTitleButton
            // 
            this.searchTitleButton.Location = new System.Drawing.Point(993, 189);
            this.searchTitleButton.Name = "searchTitleButton";
            this.searchTitleButton.Size = new System.Drawing.Size(140, 35);
            this.searchTitleButton.TabIndex = 3;
            this.searchTitleButton.Text = "Search Title";
            this.searchTitleButton.UseVisualStyleBackColor = true;
            this.searchTitleButton.Click += new System.EventHandler(this.searchTitleButton_Click);
            // 
            // searchGenreButton
            // 
            this.searchGenreButton.Location = new System.Drawing.Point(992, 230);
            this.searchGenreButton.Name = "searchGenreButton";
            this.searchGenreButton.Size = new System.Drawing.Size(140, 35);
            this.searchGenreButton.TabIndex = 4;
            this.searchGenreButton.Text = "Search Genre";
            this.searchGenreButton.UseVisualStyleBackColor = true;
            this.searchGenreButton.Click += new System.EventHandler(this.searchGenreButton_Click);
            // 
            // searchArtistButton
            // 
            this.searchArtistButton.Location = new System.Drawing.Point(993, 271);
            this.searchArtistButton.Name = "searchArtistButton";
            this.searchArtistButton.Size = new System.Drawing.Size(140, 35);
            this.searchArtistButton.TabIndex = 5;
            this.searchArtistButton.Text = "Search Artist";
            this.searchArtistButton.UseVisualStyleBackColor = true;
            this.searchArtistButton.Click += new System.EventHandler(this.searchArtistButton_Click);
            // 
            // songDataGridView
            // 
            this.songDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songDataGridView.Location = new System.Drawing.Point(377, 66);
            this.songDataGridView.Name = "songDataGridView";
            this.songDataGridView.Size = new System.Drawing.Size(587, 445);
            this.songDataGridView.TabIndex = 6;
            // 
            // albumDataGridView
            // 
            this.albumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.albumDataGridView.Location = new System.Drawing.Point(35, 66);
            this.albumDataGridView.Name = "albumDataGridView";
            this.albumDataGridView.Size = new System.Drawing.Size(297, 445);
            this.albumDataGridView.TabIndex = 7;
            this.albumDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.albumDataGridView_CellClick);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(993, 476);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 35);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumLabel.Location = new System.Drawing.Point(48, 38);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(53, 16);
            this.albumLabel.TabIndex = 9;
            this.albumLabel.Text = "Albums";
            // 
            // songsLabel
            // 
            this.songsLabel.AutoSize = true;
            this.songsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songsLabel.Location = new System.Drawing.Point(393, 38);
            this.songsLabel.Name = "songsLabel";
            this.songsLabel.Size = new System.Drawing.Size(47, 16);
            this.songsLabel.TabIndex = 10;
            this.songsLabel.Text = "Songs";
            // 
            // playListButton
            // 
            this.playListButton.Location = new System.Drawing.Point(992, 312);
            this.playListButton.Name = "playListButton";
            this.playListButton.Size = new System.Drawing.Size(141, 39);
            this.playListButton.TabIndex = 11;
            this.playListButton.Text = "Play List";
            this.playListButton.UseVisualStyleBackColor = true;
            this.playListButton.Click += new System.EventHandler(this.playListButton_Click);
            // 
            // allSongButton
            // 
            this.allSongButton.Location = new System.Drawing.Point(994, 357);
            this.allSongButton.Name = "allSongButton";
            this.allSongButton.Size = new System.Drawing.Size(139, 37);
            this.allSongButton.TabIndex = 12;
            this.allSongButton.Text = "Display All Songs";
            this.allSongButton.UseVisualStyleBackColor = true;
            this.allSongButton.Click += new System.EventHandler(this.allSongButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 586);
            this.Controls.Add(this.allSongButton);
            this.Controls.Add(this.playListButton);
            this.Controls.Add(this.songsLabel);
            this.Controls.Add(this.albumLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.albumDataGridView);
            this.Controls.Add(this.songDataGridView);
            this.Controls.Add(this.searchArtistButton);
            this.Controls.Add(this.searchGenreButton);
            this.Controls.Add(this.searchTitleButton);
            this.Controls.Add(this.rateAlbumSongButton);
            this.Controls.Add(this.addAlbumButton);
            this.Controls.Add(this.addSongButton);
            this.Name = "MainForm";
            this.Text = "Music Collection";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.Button addAlbumButton;
        private System.Windows.Forms.Button rateAlbumSongButton;
        private System.Windows.Forms.Button searchTitleButton;
        private System.Windows.Forms.Button searchGenreButton;
        private System.Windows.Forms.Button searchArtistButton;
        private System.Windows.Forms.DataGridView songDataGridView;
        private System.Windows.Forms.DataGridView albumDataGridView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Label songsLabel;
        private System.Windows.Forms.Button playListButton;
        private System.Windows.Forms.Button allSongButton;
    }
}

