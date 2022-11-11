namespace RegistrationForm
{
    partial class EditBook
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
            this.LookupButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PagesLabel = new System.Windows.Forms.Label();
            this.PagesTextbox = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.GenreTextbox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.AuthorTextbox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LookupButton
            // 
            this.LookupButton.Location = new System.Drawing.Point(132, 37);
            this.LookupButton.Name = "LookupButton";
            this.LookupButton.Size = new System.Drawing.Size(75, 23);
            this.LookupButton.TabIndex = 0;
            this.LookupButton.Text = "Lookup";
            this.LookupButton.UseVisualStyleBackColor = true;
            this.LookupButton.Click += new System.EventHandler(this.LookupButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(100, 264);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(151, 35);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PagesLabel
            // 
            this.PagesLabel.AutoSize = true;
            this.PagesLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagesLabel.Location = new System.Drawing.Point(25, 217);
            this.PagesLabel.Name = "PagesLabel";
            this.PagesLabel.Size = new System.Drawing.Size(50, 17);
            this.PagesLabel.TabIndex = 16;
            this.PagesLabel.Text = "Pages";
            // 
            // PagesTextbox
            // 
            this.PagesTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagesTextbox.Location = new System.Drawing.Point(100, 212);
            this.PagesTextbox.Name = "PagesTextbox";
            this.PagesTextbox.Size = new System.Drawing.Size(151, 22);
            this.PagesTextbox.TabIndex = 15;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(25, 134);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(56, 17);
            this.AuthorLabel.TabIndex = 14;
            this.AuthorLabel.Text = "Author";
            // 
            // GenreTextbox
            // 
            this.GenreTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreTextbox.Location = new System.Drawing.Point(100, 172);
            this.GenreTextbox.Name = "GenreTextbox";
            this.GenreTextbox.Size = new System.Drawing.Size(151, 22);
            this.GenreTextbox.TabIndex = 13;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.Location = new System.Drawing.Point(25, 177);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(53, 17);
            this.GenreLabel.TabIndex = 12;
            this.GenreLabel.Text = "Genre";
            // 
            // AuthorTextbox
            // 
            this.AuthorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorTextbox.Location = new System.Drawing.Point(100, 129);
            this.AuthorTextbox.Name = "AuthorTextbox";
            this.AuthorTextbox.Size = new System.Drawing.Size(151, 22);
            this.AuthorTextbox.TabIndex = 11;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(25, 93);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(41, 17);
            this.TitleLabel.TabIndex = 10;
            this.TitleLabel.Text = "Title";
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextbox.Location = new System.Drawing.Point(100, 92);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.Size = new System.Drawing.Size(151, 22);
            this.TitleTextbox.TabIndex = 9;
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 391);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PagesLabel);
            this.Controls.Add(this.PagesTextbox);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.GenreTextbox);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.AuthorTextbox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TitleTextbox);
            this.Controls.Add(this.LookupButton);
            this.Name = "EditBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LookupButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label PagesLabel;
        private System.Windows.Forms.TextBox PagesTextbox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox GenreTextbox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox AuthorTextbox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextbox;
    }
}