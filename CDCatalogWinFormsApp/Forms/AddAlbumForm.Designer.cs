namespace CDCatalogWinFormsApp
{
    partial class AddAlbumForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.albumYearTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.ArtistTextBox = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.albumRatingLabel = new System.Windows.Forms.Label();
            this.albumRatingGroupBox = new System.Windows.Forms.GroupBox();
            this.albumRatingRadioButton1 = new System.Windows.Forms.RadioButton();
            this.albumRatingRadioButton2 = new System.Windows.Forms.RadioButton();
            this.albumRatingRadioButton3 = new System.Windows.Forms.RadioButton();
            this.albumRatingRadioButton4 = new System.Windows.Forms.RadioButton();
            this.albumRatingRadioButton5 = new System.Windows.Forms.RadioButton();
            this.albumRatingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(103, 288);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 25);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(241, 288);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 25);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(140, 77);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(195, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(65, 80);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(59, 13);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Album Title";
            // 
            // albumYearTextBox
            // 
            this.albumYearTextBox.Location = new System.Drawing.Point(140, 115);
            this.albumYearTextBox.Name = "albumYearTextBox";
            this.albumYearTextBox.Size = new System.Drawing.Size(195, 20);
            this.albumYearTextBox.TabIndex = 4;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(63, 118);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(61, 13);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "Album Year";
            // 
            // ArtistTextBox
            // 
            this.ArtistTextBox.Location = new System.Drawing.Point(142, 159);
            this.ArtistTextBox.Name = "ArtistTextBox";
            this.ArtistTextBox.Size = new System.Drawing.Size(193, 20);
            this.ArtistTextBox.TabIndex = 6;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(92, 162);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(30, 13);
            this.artistLabel.TabIndex = 7;
            this.artistLabel.Text = "Artist";
            // 
            // albumRatingLabel
            // 
            this.albumRatingLabel.AutoSize = true;
            this.albumRatingLabel.Location = new System.Drawing.Point(52, 211);
            this.albumRatingLabel.Name = "albumRatingLabel";
            this.albumRatingLabel.Size = new System.Drawing.Size(70, 13);
            this.albumRatingLabel.TabIndex = 8;
            this.albumRatingLabel.Text = "Album Rating";
            // 
            // albumRatingGroupBox
            // 
            this.albumRatingGroupBox.Controls.Add(this.albumRatingRadioButton5);
            this.albumRatingGroupBox.Controls.Add(this.albumRatingRadioButton4);
            this.albumRatingGroupBox.Controls.Add(this.albumRatingRadioButton3);
            this.albumRatingGroupBox.Controls.Add(this.albumRatingRadioButton2);
            this.albumRatingGroupBox.Controls.Add(this.albumRatingRadioButton1);
            this.albumRatingGroupBox.Location = new System.Drawing.Point(140, 196);
            this.albumRatingGroupBox.Name = "albumRatingGroupBox";
            this.albumRatingGroupBox.Size = new System.Drawing.Size(195, 37);
            this.albumRatingGroupBox.TabIndex = 9;
            this.albumRatingGroupBox.TabStop = false;
            // 
            // albumRatingRadioButton1
            // 
            this.albumRatingRadioButton1.AutoSize = true;
            this.albumRatingRadioButton1.Location = new System.Drawing.Point(6, 13);
            this.albumRatingRadioButton1.Name = "albumRatingRadioButton1";
            this.albumRatingRadioButton1.Size = new System.Drawing.Size(31, 17);
            this.albumRatingRadioButton1.TabIndex = 0;
            this.albumRatingRadioButton1.TabStop = true;
            this.albumRatingRadioButton1.Text = "1";
            this.albumRatingRadioButton1.UseVisualStyleBackColor = true;
            // 
            // albumRatingRadioButton2
            // 
            this.albumRatingRadioButton2.AutoSize = true;
            this.albumRatingRadioButton2.Location = new System.Drawing.Point(43, 13);
            this.albumRatingRadioButton2.Name = "albumRatingRadioButton2";
            this.albumRatingRadioButton2.Size = new System.Drawing.Size(31, 17);
            this.albumRatingRadioButton2.TabIndex = 1;
            this.albumRatingRadioButton2.TabStop = true;
            this.albumRatingRadioButton2.Text = "2";
            this.albumRatingRadioButton2.UseVisualStyleBackColor = true;
            // 
            // albumRatingRadioButton3
            // 
            this.albumRatingRadioButton3.AutoSize = true;
            this.albumRatingRadioButton3.Location = new System.Drawing.Point(80, 13);
            this.albumRatingRadioButton3.Name = "albumRatingRadioButton3";
            this.albumRatingRadioButton3.Size = new System.Drawing.Size(31, 17);
            this.albumRatingRadioButton3.TabIndex = 2;
            this.albumRatingRadioButton3.TabStop = true;
            this.albumRatingRadioButton3.Text = "3";
            this.albumRatingRadioButton3.UseVisualStyleBackColor = true;
            // 
            // albumRatingRadioButton4
            // 
            this.albumRatingRadioButton4.AutoSize = true;
            this.albumRatingRadioButton4.Location = new System.Drawing.Point(117, 13);
            this.albumRatingRadioButton4.Name = "albumRatingRadioButton4";
            this.albumRatingRadioButton4.Size = new System.Drawing.Size(31, 17);
            this.albumRatingRadioButton4.TabIndex = 3;
            this.albumRatingRadioButton4.TabStop = true;
            this.albumRatingRadioButton4.Text = "4";
            this.albumRatingRadioButton4.UseVisualStyleBackColor = true;
            // 
            // albumRatingRadioButton5
            // 
            this.albumRatingRadioButton5.AutoSize = true;
            this.albumRatingRadioButton5.Location = new System.Drawing.Point(154, 13);
            this.albumRatingRadioButton5.Name = "albumRatingRadioButton5";
            this.albumRatingRadioButton5.Size = new System.Drawing.Size(31, 17);
            this.albumRatingRadioButton5.TabIndex = 4;
            this.albumRatingRadioButton5.TabStop = true;
            this.albumRatingRadioButton5.Text = "5";
            this.albumRatingRadioButton5.UseVisualStyleBackColor = true;
            // 
            // AddAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.albumRatingGroupBox);
            this.Controls.Add(this.albumRatingLabel);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.ArtistTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.albumYearTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Name = "AddAlbumForm";
            this.Text = "Add Album";
            this.albumRatingGroupBox.ResumeLayout(false);
            this.albumRatingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox albumYearTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox ArtistTextBox;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label albumRatingLabel;
        private System.Windows.Forms.GroupBox albumRatingGroupBox;
        private System.Windows.Forms.RadioButton albumRatingRadioButton5;
        private System.Windows.Forms.RadioButton albumRatingRadioButton4;
        private System.Windows.Forms.RadioButton albumRatingRadioButton3;
        private System.Windows.Forms.RadioButton albumRatingRadioButton2;
        private System.Windows.Forms.RadioButton albumRatingRadioButton1;
    }
}