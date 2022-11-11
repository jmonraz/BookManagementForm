namespace RegistrationForm
{
    partial class DisplayBooks
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
            this.BooksListbox = new System.Windows.Forms.ListBox();
            this.TitleTextbox = new System.Windows.Forms.TextBox();
            this.AuthorTextbox = new System.Windows.Forms.TextBox();
            this.GenreTextbox = new System.Windows.Forms.TextBox();
            this.NumberOfPagesTextbox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.NumberOfPagesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BooksListbox
            // 
            this.BooksListbox.FormattingEnabled = true;
            this.BooksListbox.Location = new System.Drawing.Point(31, 26);
            this.BooksListbox.Name = "BooksListbox";
            this.BooksListbox.Size = new System.Drawing.Size(267, 355);
            this.BooksListbox.TabIndex = 0;
            this.BooksListbox.SelectedIndexChanged += new System.EventHandler(this.BooksListbox_SelectedIndexChanged);
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextbox.Location = new System.Drawing.Point(372, 60);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.ReadOnly = true;
            this.TitleTextbox.Size = new System.Drawing.Size(248, 21);
            this.TitleTextbox.TabIndex = 1;
            // 
            // AuthorTextbox
            // 
            this.AuthorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorTextbox.Location = new System.Drawing.Point(372, 110);
            this.AuthorTextbox.Name = "AuthorTextbox";
            this.AuthorTextbox.ReadOnly = true;
            this.AuthorTextbox.Size = new System.Drawing.Size(248, 21);
            this.AuthorTextbox.TabIndex = 2;
            // 
            // GenreTextbox
            // 
            this.GenreTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreTextbox.Location = new System.Drawing.Point(372, 170);
            this.GenreTextbox.Name = "GenreTextbox";
            this.GenreTextbox.ReadOnly = true;
            this.GenreTextbox.Size = new System.Drawing.Size(248, 21);
            this.GenreTextbox.TabIndex = 3;
            // 
            // NumberOfPagesTextbox
            // 
            this.NumberOfPagesTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfPagesTextbox.Location = new System.Drawing.Point(372, 223);
            this.NumberOfPagesTextbox.Name = "NumberOfPagesTextbox";
            this.NumberOfPagesTextbox.ReadOnly = true;
            this.NumberOfPagesTextbox.Size = new System.Drawing.Size(248, 21);
            this.NumberOfPagesTextbox.TabIndex = 4;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(467, 41);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(33, 16);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Title";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(467, 91);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(45, 16);
            this.AuthorLabel.TabIndex = 6;
            this.AuthorLabel.Text = "Author";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.Location = new System.Drawing.Point(467, 151);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(44, 16);
            this.GenreLabel.TabIndex = 7;
            this.GenreLabel.Text = "Genre";
            // 
            // NumberOfPagesLabel
            // 
            this.NumberOfPagesLabel.AutoSize = true;
            this.NumberOfPagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfPagesLabel.Location = new System.Drawing.Point(441, 204);
            this.NumberOfPagesLabel.Name = "NumberOfPagesLabel";
            this.NumberOfPagesLabel.Size = new System.Drawing.Size(112, 16);
            this.NumberOfPagesLabel.TabIndex = 8;
            this.NumberOfPagesLabel.Text = "Number of Pages";
            // 
            // DisplayBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 420);
            this.Controls.Add(this.NumberOfPagesLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.NumberOfPagesTextbox);
            this.Controls.Add(this.GenreTextbox);
            this.Controls.Add(this.AuthorTextbox);
            this.Controls.Add(this.TitleTextbox);
            this.Controls.Add(this.BooksListbox);
            this.Name = "DisplayBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BooksListbox;
        private System.Windows.Forms.TextBox TitleTextbox;
        private System.Windows.Forms.TextBox AuthorTextbox;
        private System.Windows.Forms.TextBox GenreTextbox;
        private System.Windows.Forms.TextBox NumberOfPagesTextbox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label NumberOfPagesLabel;
    }
}