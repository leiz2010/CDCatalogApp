namespace CDCatalogWinFormsApp
{
    partial class AlbumDetailForm
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
            this.albumDetialLabel = new System.Windows.Forms.Label();
            this.songsOnAlbumLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.songDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // albumDetialLabel
            // 
            this.albumDetialLabel.AutoSize = true;
            this.albumDetialLabel.Location = new System.Drawing.Point(61, 39);
            this.albumDetialLabel.Name = "albumDetialLabel";
            this.albumDetialLabel.Size = new System.Drawing.Size(72, 13);
            this.albumDetialLabel.TabIndex = 1;
            this.albumDetialLabel.Text = "Album Detail: ";
            // 
            // songsOnAlbumLabel
            // 
            this.songsOnAlbumLabel.AutoSize = true;
            this.songsOnAlbumLabel.Location = new System.Drawing.Point(61, 70);
            this.songsOnAlbumLabel.Name = "songsOnAlbumLabel";
            this.songsOnAlbumLabel.Size = new System.Drawing.Size(103, 13);
            this.songsOnAlbumLabel.TabIndex = 2;
            this.songsOnAlbumLabel.Text = "Songs on this Album";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(337, 406);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(116, 30);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // songDataGridView
            // 
            this.songDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songDataGridView.Location = new System.Drawing.Point(68, 105);
            this.songDataGridView.Name = "songDataGridView";
            this.songDataGridView.Size = new System.Drawing.Size(647, 256);
            this.songDataGridView.TabIndex = 4;
            // 
            // AlbumDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 479);
            this.Controls.Add(this.songDataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.songsOnAlbumLabel);
            this.Controls.Add(this.albumDetialLabel);
            this.Name = "AlbumDetailForm";
            this.Text = "AlbumDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label albumDetialLabel;
        private System.Windows.Forms.Label songsOnAlbumLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView songDataGridView;
    }
}