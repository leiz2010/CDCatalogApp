namespace CDCatalogWinFormsApp
{
    partial class SongDetialForm
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
            this.songDetailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // songDetailLabel
            // 
            this.songDetailLabel.AutoSize = true;
            this.songDetailLabel.Location = new System.Drawing.Point(56, 41);
            this.songDetailLabel.Name = "songDetailLabel";
            this.songDetailLabel.Size = new System.Drawing.Size(68, 13);
            this.songDetailLabel.TabIndex = 0;
            this.songDetailLabel.Text = "Song Detial: ";
            // 
            // SongDetialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 336);
            this.Controls.Add(this.songDetailLabel);
            this.Name = "SongDetialForm";
            this.Text = "Song Detial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label songDetailLabel;
    }
}