namespace CDCatalogWinFormsApp
{
    partial class RateItemForm
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
            this.ratingRadioButtonOne = new System.Windows.Forms.RadioButton();
            this.ratingRadioButtonTwo = new System.Windows.Forms.RadioButton();
            this.ratingRadioButtonThree = new System.Windows.Forms.RadioButton();
            this.ratingRadioButtonFour = new System.Windows.Forms.RadioButton();
            this.ratingRadioButtonFive = new System.Windows.Forms.RadioButton();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ratingRadioButtonOne
            // 
            this.ratingRadioButtonOne.AutoSize = true;
            this.ratingRadioButtonOne.Location = new System.Drawing.Point(140, 59);
            this.ratingRadioButtonOne.Name = "ratingRadioButtonOne";
            this.ratingRadioButtonOne.Size = new System.Drawing.Size(31, 17);
            this.ratingRadioButtonOne.TabIndex = 0;
            this.ratingRadioButtonOne.TabStop = true;
            this.ratingRadioButtonOne.Text = "1";
            this.ratingRadioButtonOne.UseVisualStyleBackColor = true;
            // 
            // ratingRadioButtonTwo
            // 
            this.ratingRadioButtonTwo.AutoSize = true;
            this.ratingRadioButtonTwo.Location = new System.Drawing.Point(196, 59);
            this.ratingRadioButtonTwo.Name = "ratingRadioButtonTwo";
            this.ratingRadioButtonTwo.Size = new System.Drawing.Size(31, 17);
            this.ratingRadioButtonTwo.TabIndex = 1;
            this.ratingRadioButtonTwo.TabStop = true;
            this.ratingRadioButtonTwo.Text = "2";
            this.ratingRadioButtonTwo.UseVisualStyleBackColor = true;
            // 
            // ratingRadioButtonThree
            // 
            this.ratingRadioButtonThree.AutoSize = true;
            this.ratingRadioButtonThree.Location = new System.Drawing.Point(255, 59);
            this.ratingRadioButtonThree.Name = "ratingRadioButtonThree";
            this.ratingRadioButtonThree.Size = new System.Drawing.Size(31, 17);
            this.ratingRadioButtonThree.TabIndex = 2;
            this.ratingRadioButtonThree.TabStop = true;
            this.ratingRadioButtonThree.Text = "3";
            this.ratingRadioButtonThree.UseVisualStyleBackColor = true;
            // 
            // ratingRadioButtonFour
            // 
            this.ratingRadioButtonFour.AutoSize = true;
            this.ratingRadioButtonFour.Location = new System.Drawing.Point(313, 59);
            this.ratingRadioButtonFour.Name = "ratingRadioButtonFour";
            this.ratingRadioButtonFour.Size = new System.Drawing.Size(31, 17);
            this.ratingRadioButtonFour.TabIndex = 3;
            this.ratingRadioButtonFour.TabStop = true;
            this.ratingRadioButtonFour.Text = "4";
            this.ratingRadioButtonFour.UseVisualStyleBackColor = true;
            // 
            // ratingRadioButtonFive
            // 
            this.ratingRadioButtonFive.AutoSize = true;
            this.ratingRadioButtonFive.Location = new System.Drawing.Point(368, 59);
            this.ratingRadioButtonFive.Name = "ratingRadioButtonFive";
            this.ratingRadioButtonFive.Size = new System.Drawing.Size(31, 17);
            this.ratingRadioButtonFive.TabIndex = 4;
            this.ratingRadioButtonFive.TabStop = true;
            this.ratingRadioButtonFive.Text = "5";
            this.ratingRadioButtonFive.UseVisualStyleBackColor = true;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(137, 20);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(13, 13);
            this.ratingLabel.TabIndex = 5;
            this.ratingLabel.Text = "  ";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(215, 96);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(115, 28);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // RateItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 149);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.ratingRadioButtonFive);
            this.Controls.Add(this.ratingRadioButtonFour);
            this.Controls.Add(this.ratingRadioButtonThree);
            this.Controls.Add(this.ratingRadioButtonTwo);
            this.Controls.Add(this.ratingRadioButtonOne);
            this.Name = "RateItemForm";
            this.Text = "Give Rating";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ratingRadioButtonOne;
        private System.Windows.Forms.RadioButton ratingRadioButtonTwo;
        private System.Windows.Forms.RadioButton ratingRadioButtonThree;
        private System.Windows.Forms.RadioButton ratingRadioButtonFour;
        private System.Windows.Forms.RadioButton ratingRadioButtonFive;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Button okButton;
    }
}