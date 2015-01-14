namespace CDCatalogWinFormsApp
{
    partial class AddSongForm
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
            this.albumTextBox = new System.Windows.Forms.TextBox();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.trackNumberTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.albumTitleLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackNumberLabel = new System.Windows.Forms.Label();
            this.trackLengthTextBox = new System.Windows.Forms.TextBox();
            this.trackLengthLabel = new System.Windows.Forms.Label();
            this.songRatingRadioButton1 = new System.Windows.Forms.RadioButton();
            this.songRatingGroupBox = new System.Windows.Forms.GroupBox();
            this.songRatingRadioButton5 = new System.Windows.Forms.RadioButton();
            this.songRatingRadioButton4 = new System.Windows.Forms.RadioButton();
            this.songRatingRadioButton3 = new System.Windows.Forms.RadioButton();
            this.songRatingRadioButton2 = new System.Windows.Forms.RadioButton();
            this.songRateLabel = new System.Windows.Forms.Label();
            this.songRatingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(115, 354);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 24);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(237, 354);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 24);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(142, 59);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(196, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // albumTextBox
            // 
            this.albumTextBox.Location = new System.Drawing.Point(143, 96);
            this.albumTextBox.Name = "albumTextBox";
            this.albumTextBox.Size = new System.Drawing.Size(195, 20);
            this.albumTextBox.TabIndex = 3;
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(142, 134);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(196, 20);
            this.artistTextBox.TabIndex = 4;
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(142, 171);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(196, 20);
            this.genreTextBox.TabIndex = 5;
            // 
            // trackNumberTextBox
            // 
            this.trackNumberTextBox.Location = new System.Drawing.Point(142, 210);
            this.trackNumberTextBox.Name = "trackNumberTextBox";
            this.trackNumberTextBox.Size = new System.Drawing.Size(196, 20);
            this.trackNumberTextBox.TabIndex = 6;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(66, 62);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(55, 13);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Song Title";
            // 
            // albumTitleLabel
            // 
            this.albumTitleLabel.AutoSize = true;
            this.albumTitleLabel.Location = new System.Drawing.Point(62, 99);
            this.albumTitleLabel.Name = "albumTitleLabel";
            this.albumTitleLabel.Size = new System.Drawing.Size(59, 13);
            this.albumTitleLabel.TabIndex = 8;
            this.albumTitleLabel.Text = "Album Title";
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(91, 137);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(30, 13);
            this.artistLabel.TabIndex = 9;
            this.artistLabel.Text = "Artist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Genre";
            // 
            // trackNumberLabel
            // 
            this.trackNumberLabel.AutoSize = true;
            this.trackNumberLabel.Location = new System.Drawing.Point(46, 210);
            this.trackNumberLabel.Name = "trackNumberLabel";
            this.trackNumberLabel.Size = new System.Drawing.Size(75, 13);
            this.trackNumberLabel.TabIndex = 11;
            this.trackNumberLabel.Text = "Track Number";
            // 
            // trackLengthTextBox
            // 
            this.trackLengthTextBox.Location = new System.Drawing.Point(142, 247);
            this.trackLengthTextBox.Name = "trackLengthTextBox";
            this.trackLengthTextBox.Size = new System.Drawing.Size(196, 20);
            this.trackLengthTextBox.TabIndex = 12;
            // 
            // trackLengthLabel
            // 
            this.trackLengthLabel.AutoSize = true;
            this.trackLengthLabel.Location = new System.Drawing.Point(50, 247);
            this.trackLengthLabel.Name = "trackLengthLabel";
            this.trackLengthLabel.Size = new System.Drawing.Size(71, 13);
            this.trackLengthLabel.TabIndex = 13;
            this.trackLengthLabel.Text = "Track Length";
            // 
            // songRatingRadioButton1
            // 
            this.songRatingRadioButton1.AutoSize = true;
            this.songRatingRadioButton1.Location = new System.Drawing.Point(6, 13);
            this.songRatingRadioButton1.Name = "songRatingRadioButton1";
            this.songRatingRadioButton1.Size = new System.Drawing.Size(31, 17);
            this.songRatingRadioButton1.TabIndex = 14;
            this.songRatingRadioButton1.TabStop = true;
            this.songRatingRadioButton1.Text = "1";
            this.songRatingRadioButton1.UseVisualStyleBackColor = true;
            // 
            // songRatingGroupBox
            // 
            this.songRatingGroupBox.Controls.Add(this.songRatingRadioButton5);
            this.songRatingGroupBox.Controls.Add(this.songRatingRadioButton4);
            this.songRatingGroupBox.Controls.Add(this.songRatingRadioButton3);
            this.songRatingGroupBox.Controls.Add(this.songRatingRadioButton2);
            this.songRatingGroupBox.Controls.Add(this.songRatingRadioButton1);
            this.songRatingGroupBox.Location = new System.Drawing.Point(143, 273);
            this.songRatingGroupBox.Name = "songRatingGroupBox";
            this.songRatingGroupBox.Size = new System.Drawing.Size(195, 35);
            this.songRatingGroupBox.TabIndex = 15;
            this.songRatingGroupBox.TabStop = false;
            // 
            // songRatingRadioButton5
            // 
            this.songRatingRadioButton5.AutoSize = true;
            this.songRatingRadioButton5.Location = new System.Drawing.Point(150, 13);
            this.songRatingRadioButton5.Name = "songRatingRadioButton5";
            this.songRatingRadioButton5.Size = new System.Drawing.Size(31, 17);
            this.songRatingRadioButton5.TabIndex = 18;
            this.songRatingRadioButton5.TabStop = true;
            this.songRatingRadioButton5.Text = "5";
            this.songRatingRadioButton5.UseVisualStyleBackColor = true;
            // 
            // songRatingRadioButton4
            // 
            this.songRatingRadioButton4.AutoSize = true;
            this.songRatingRadioButton4.Location = new System.Drawing.Point(117, 13);
            this.songRatingRadioButton4.Name = "songRatingRadioButton4";
            this.songRatingRadioButton4.Size = new System.Drawing.Size(31, 17);
            this.songRatingRadioButton4.TabIndex = 17;
            this.songRatingRadioButton4.TabStop = true;
            this.songRatingRadioButton4.Text = "4";
            this.songRatingRadioButton4.UseVisualStyleBackColor = true;
            // 
            // songRatingRadioButton3
            // 
            this.songRatingRadioButton3.AutoSize = true;
            this.songRatingRadioButton3.Location = new System.Drawing.Point(80, 13);
            this.songRatingRadioButton3.Name = "songRatingRadioButton3";
            this.songRatingRadioButton3.Size = new System.Drawing.Size(31, 17);
            this.songRatingRadioButton3.TabIndex = 16;
            this.songRatingRadioButton3.TabStop = true;
            this.songRatingRadioButton3.Text = "3";
            this.songRatingRadioButton3.UseVisualStyleBackColor = true;
            // 
            // songRatingRadioButton2
            // 
            this.songRatingRadioButton2.AutoSize = true;
            this.songRatingRadioButton2.Location = new System.Drawing.Point(43, 13);
            this.songRatingRadioButton2.Name = "songRatingRadioButton2";
            this.songRatingRadioButton2.Size = new System.Drawing.Size(31, 17);
            this.songRatingRadioButton2.TabIndex = 15;
            this.songRatingRadioButton2.TabStop = true;
            this.songRatingRadioButton2.Text = "2";
            this.songRatingRadioButton2.UseVisualStyleBackColor = true;
            // 
            // songRateLabel
            // 
            this.songRateLabel.AutoSize = true;
            this.songRateLabel.Location = new System.Drawing.Point(55, 286);
            this.songRateLabel.Name = "songRateLabel";
            this.songRateLabel.Size = new System.Drawing.Size(66, 13);
            this.songRateLabel.TabIndex = 16;
            this.songRateLabel.Text = "Song Rating";
            // 
            // AddSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.songRateLabel);
            this.Controls.Add(this.songRatingGroupBox);
            this.Controls.Add(this.trackLengthLabel);
            this.Controls.Add(this.trackLengthTextBox);
            this.Controls.Add(this.trackNumberLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.albumTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.trackNumberTextBox);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.albumTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Name = "AddSongForm";
            this.Text = "Add Song";
            this.songRatingGroupBox.ResumeLayout(false);
            this.songRatingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox albumTextBox;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox trackNumberTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label albumTitleLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label trackNumberLabel;
        private System.Windows.Forms.TextBox trackLengthTextBox;
        private System.Windows.Forms.Label trackLengthLabel;
        private System.Windows.Forms.RadioButton songRatingRadioButton1;
        private System.Windows.Forms.GroupBox songRatingGroupBox;
        private System.Windows.Forms.RadioButton songRatingRadioButton5;
        private System.Windows.Forms.RadioButton songRatingRadioButton4;
        private System.Windows.Forms.RadioButton songRatingRadioButton3;
        private System.Windows.Forms.RadioButton songRatingRadioButton2;
        private System.Windows.Forms.Label songRateLabel;
    }
}