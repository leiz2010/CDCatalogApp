namespace CDCatalogWinFormsApp
{
    partial class RateForm
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
            this.rateAlbumButton = new System.Windows.Forms.Button();
            this.rateSongButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rateAlbumButton
            // 
            this.rateAlbumButton.Location = new System.Drawing.Point(110, 56);
            this.rateAlbumButton.Name = "rateAlbumButton";
            this.rateAlbumButton.Size = new System.Drawing.Size(130, 36);
            this.rateAlbumButton.TabIndex = 0;
            this.rateAlbumButton.Text = "Rate Album";
            this.rateAlbumButton.UseVisualStyleBackColor = true;
            this.rateAlbumButton.Click += new System.EventHandler(this.rateAlbumButton_Click);
            // 
            // rateSongButton
            // 
            this.rateSongButton.Location = new System.Drawing.Point(281, 56);
            this.rateSongButton.Name = "rateSongButton";
            this.rateSongButton.Size = new System.Drawing.Size(130, 36);
            this.rateSongButton.TabIndex = 1;
            this.rateSongButton.Text = "Rate Song";
            this.rateSongButton.UseVisualStyleBackColor = true;
            this.rateSongButton.Click += new System.EventHandler(this.rateSongButton_Click);
            // 
            // RateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 142);
            this.Controls.Add(this.rateSongButton);
            this.Controls.Add(this.rateAlbumButton);
            this.Name = "RateForm";
            this.Text = "Rate an Album or Song";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rateAlbumButton;
        private System.Windows.Forms.Button rateSongButton;
    }
}