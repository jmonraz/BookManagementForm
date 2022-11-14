namespace RegistrationForm
{
    partial class SearchForm
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
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.booksListbox = new System.Windows.Forms.ListBox();
            this.NumberOfPagesLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NumberOfPagesTextbox = new System.Windows.Forms.TextBox();
            this.GenreTextbox = new System.Windows.Forms.TextBox();
            this.AuthorTextbox = new System.Windows.Forms.TextBox();
            this.TitleTextbox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.radioButtonAuthor = new System.Windows.Forms.RadioButton();
            this.radioButtonGenre = new System.Windows.Forms.RadioButton();
            this.radioButtonTitle = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(25, 50);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(257, 20);
            this.searchTextbox.TabIndex = 0;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // booksListbox
            // 
            this.booksListbox.FormattingEnabled = true;
            this.booksListbox.Location = new System.Drawing.Point(25, 91);
            this.booksListbox.Name = "booksListbox";
            this.booksListbox.Size = new System.Drawing.Size(257, 342);
            this.booksListbox.TabIndex = 1;
            this.booksListbox.SelectedIndexChanged += new System.EventHandler(this.booksListbox_SelectedIndexChanged);
            // 
            // NumberOfPagesLabel
            // 
            this.NumberOfPagesLabel.AutoSize = true;
            this.NumberOfPagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfPagesLabel.Location = new System.Drawing.Point(379, 315);
            this.NumberOfPagesLabel.Name = "NumberOfPagesLabel";
            this.NumberOfPagesLabel.Size = new System.Drawing.Size(112, 16);
            this.NumberOfPagesLabel.TabIndex = 16;
            this.NumberOfPagesLabel.Text = "Number of Pages";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.Location = new System.Drawing.Point(405, 262);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(44, 16);
            this.GenreLabel.TabIndex = 15;
            this.GenreLabel.Text = "Genre";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(405, 202);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(45, 16);
            this.AuthorLabel.TabIndex = 14;
            this.AuthorLabel.Text = "Author";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(405, 152);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(33, 16);
            this.TitleLabel.TabIndex = 13;
            this.TitleLabel.Text = "Title";
            // 
            // NumberOfPagesTextbox
            // 
            this.NumberOfPagesTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfPagesTextbox.Location = new System.Drawing.Point(310, 334);
            this.NumberOfPagesTextbox.Name = "NumberOfPagesTextbox";
            this.NumberOfPagesTextbox.ReadOnly = true;
            this.NumberOfPagesTextbox.Size = new System.Drawing.Size(248, 21);
            this.NumberOfPagesTextbox.TabIndex = 12;
            // 
            // GenreTextbox
            // 
            this.GenreTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreTextbox.Location = new System.Drawing.Point(310, 281);
            this.GenreTextbox.Name = "GenreTextbox";
            this.GenreTextbox.ReadOnly = true;
            this.GenreTextbox.Size = new System.Drawing.Size(248, 21);
            this.GenreTextbox.TabIndex = 11;
            // 
            // AuthorTextbox
            // 
            this.AuthorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorTextbox.Location = new System.Drawing.Point(310, 221);
            this.AuthorTextbox.Name = "AuthorTextbox";
            this.AuthorTextbox.ReadOnly = true;
            this.AuthorTextbox.Size = new System.Drawing.Size(248, 21);
            this.AuthorTextbox.TabIndex = 10;
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextbox.Location = new System.Drawing.Point(310, 171);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.ReadOnly = true;
            this.TitleTextbox.Size = new System.Drawing.Size(248, 21);
            this.TitleTextbox.TabIndex = 9;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(25, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(46, 23);
            this.BackButton.TabIndex = 30;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // radioButtonAuthor
            // 
            this.radioButtonAuthor.AutoSize = true;
            this.radioButtonAuthor.Location = new System.Drawing.Point(333, 73);
            this.radioButtonAuthor.Name = "radioButtonAuthor";
            this.radioButtonAuthor.Size = new System.Drawing.Size(71, 17);
            this.radioButtonAuthor.TabIndex = 31;
            this.radioButtonAuthor.TabStop = true;
            this.radioButtonAuthor.Text = "By Author";
            this.radioButtonAuthor.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenre
            // 
            this.radioButtonGenre.AutoSize = true;
            this.radioButtonGenre.Location = new System.Drawing.Point(333, 50);
            this.radioButtonGenre.Name = "radioButtonGenre";
            this.radioButtonGenre.Size = new System.Drawing.Size(69, 17);
            this.radioButtonGenre.TabIndex = 32;
            this.radioButtonGenre.TabStop = true;
            this.radioButtonGenre.Text = "By Genre";
            this.radioButtonGenre.UseVisualStyleBackColor = true;
            // 
            // radioButtonTitle
            // 
            this.radioButtonTitle.AutoSize = true;
            this.radioButtonTitle.Checked = true;
            this.radioButtonTitle.Location = new System.Drawing.Point(333, 27);
            this.radioButtonTitle.Name = "radioButtonTitle";
            this.radioButtonTitle.Size = new System.Drawing.Size(60, 17);
            this.radioButtonTitle.TabIndex = 33;
            this.radioButtonTitle.TabStop = true;
            this.radioButtonTitle.Text = "By Title";
            this.radioButtonTitle.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 464);
            this.ControlBox = false;
            this.Controls.Add(this.radioButtonTitle);
            this.Controls.Add(this.radioButtonGenre);
            this.Controls.Add(this.radioButtonAuthor);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NumberOfPagesLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.NumberOfPagesTextbox);
            this.Controls.Add(this.GenreTextbox);
            this.Controls.Add(this.AuthorTextbox);
            this.Controls.Add(this.TitleTextbox);
            this.Controls.Add(this.booksListbox);
            this.Controls.Add(this.searchTextbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.ListBox booksListbox;
        private System.Windows.Forms.Label NumberOfPagesLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox NumberOfPagesTextbox;
        private System.Windows.Forms.TextBox GenreTextbox;
        private System.Windows.Forms.TextBox AuthorTextbox;
        private System.Windows.Forms.TextBox TitleTextbox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.RadioButton radioButtonAuthor;
        private System.Windows.Forms.RadioButton radioButtonGenre;
        private System.Windows.Forms.RadioButton radioButtonTitle;
    }
}