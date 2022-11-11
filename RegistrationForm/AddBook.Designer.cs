namespace RegistrationForm
{
    partial class AddBook
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
            this.TitleTextbox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.AuthorTextbox = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.GenreTextbox = new System.Windows.Forms.TextBox();
            this.PagesLabel = new System.Windows.Forms.Label();
            this.PagesTextbox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Location = new System.Drawing.Point(146, 54);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextbox.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(64, 57);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(64, 141);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(36, 13);
            this.GenreLabel.TabIndex = 3;
            this.GenreLabel.Text = "Genre";
            // 
            // AuthorTextbox
            // 
            this.AuthorTextbox.Location = new System.Drawing.Point(146, 91);
            this.AuthorTextbox.Name = "AuthorTextbox";
            this.AuthorTextbox.Size = new System.Drawing.Size(100, 20);
            this.AuthorTextbox.TabIndex = 2;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(64, 98);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(38, 13);
            this.AuthorLabel.TabIndex = 5;
            this.AuthorLabel.Text = "Author";
            // 
            // GenreTextbox
            // 
            this.GenreTextbox.Location = new System.Drawing.Point(146, 134);
            this.GenreTextbox.Name = "GenreTextbox";
            this.GenreTextbox.Size = new System.Drawing.Size(100, 20);
            this.GenreTextbox.TabIndex = 4;
            // 
            // PagesLabel
            // 
            this.PagesLabel.AutoSize = true;
            this.PagesLabel.Location = new System.Drawing.Point(64, 181);
            this.PagesLabel.Name = "PagesLabel";
            this.PagesLabel.Size = new System.Drawing.Size(37, 13);
            this.PagesLabel.TabIndex = 7;
            this.PagesLabel.Text = "Pages";
            // 
            // PagesTextbox
            // 
            this.PagesTextbox.Location = new System.Drawing.Point(146, 174);
            this.PagesTextbox.Name = "PagesTextbox";
            this.PagesTextbox.Size = new System.Drawing.Size(100, 20);
            this.PagesTextbox.TabIndex = 6;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(146, 239);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 43);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 392);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PagesLabel);
            this.Controls.Add(this.PagesTextbox);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.GenreTextbox);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.AuthorTextbox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TitleTextbox);
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextbox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox AuthorTextbox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox GenreTextbox;
        private System.Windows.Forms.Label PagesLabel;
        private System.Windows.Forms.TextBox PagesTextbox;
        private System.Windows.Forms.Button SaveButton;
    }
}