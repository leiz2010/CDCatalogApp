namespace CDCatalogWinFormsApp
{
    partial class PlayListForm
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
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.listLengthLabel = new System.Windows.Forms.Label();
            this.durationButton = new System.Windows.Forms.Button();
            this.playListDataGridView = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(397, 68);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(86, 20);
            this.lengthTextBox.TabIndex = 0;
            // 
            // listLengthLabel
            // 
            this.listLengthLabel.AutoSize = true;
            this.listLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLengthLabel.Location = new System.Drawing.Point(107, 68);
            this.listLengthLabel.Name = "listLengthLabel";
            this.listLengthLabel.Size = new System.Drawing.Size(284, 18);
            this.listLengthLabel.TabIndex = 1;
            this.listLengthLabel.Text = "Please enter the playlist length in minutes: ";
            // 
            // durationButton
            // 
            this.durationButton.Location = new System.Drawing.Point(505, 62);
            this.durationButton.Name = "durationButton";
            this.durationButton.Size = new System.Drawing.Size(116, 31);
            this.durationButton.TabIndex = 2;
            this.durationButton.Text = "Create Playlist";
            this.durationButton.UseVisualStyleBackColor = true;
            this.durationButton.Click += new System.EventHandler(this.durationButton_Click);
            // 
            // playListDataGridView
            // 
            this.playListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playListDataGridView.Location = new System.Drawing.Point(61, 126);
            this.playListDataGridView.Name = "playListDataGridView";
            this.playListDataGridView.Size = new System.Drawing.Size(618, 397);
            this.playListDataGridView.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(332, 549);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(142, 32);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // PlayListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 606);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playListDataGridView);
            this.Controls.Add(this.durationButton);
            this.Controls.Add(this.listLengthLabel);
            this.Controls.Add(this.lengthTextBox);
            this.Name = "PlayListForm";
            this.Text = "Crate a Playlist";
            ((System.ComponentModel.ISupportInitialize)(this.playListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label listLengthLabel;
        private System.Windows.Forms.Button durationButton;
        private System.Windows.Forms.DataGridView playListDataGridView;
        private System.Windows.Forms.Button exitButton;
    }
}