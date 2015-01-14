namespace CDCatalogWinFormsApp
{
    partial class RateAlbumSongForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.rateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.rateAlbumSongLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(88, 44);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(173, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(291, 37);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 27);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(88, 144);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(330, 329);
            this.resultListBox.TabIndex = 2;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(109, 102);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(0, 13);
            this.searchLabel.TabIndex = 3;
            // 
            // rateButton
            // 
            this.rateButton.Location = new System.Drawing.Point(125, 505);
            this.rateButton.Name = "rateButton";
            this.rateButton.Size = new System.Drawing.Size(115, 29);
            this.rateButton.TabIndex = 4;
            this.rateButton.Text = "Rate";
            this.rateButton.UseVisualStyleBackColor = true;
            this.rateButton.Click += new System.EventHandler(this.rateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(279, 505);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 29);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // rateAlbumSongLabel
            // 
            this.rateAlbumSongLabel.AutoSize = true;
            this.rateAlbumSongLabel.Location = new System.Drawing.Point(85, 115);
            this.rateAlbumSongLabel.Name = "rateAlbumSongLabel";
            this.rateAlbumSongLabel.Size = new System.Drawing.Size(173, 13);
            this.rateAlbumSongLabel.TabIndex = 6;
            this.rateAlbumSongLabel.Text = "Select a search result to give rating";
            // 
            // RateAlbumSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 570);
            this.Controls.Add(this.rateAlbumSongLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.rateButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Name = "RateAlbumSongForm";
            this.Text = "Find the Song to Rate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button rateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label rateAlbumSongLabel;
    }
}