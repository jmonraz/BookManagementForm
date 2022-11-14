namespace RegistrationForm
{
    partial class LibraryManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryManagementForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.bookManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.progressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressByBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritePhrasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPhraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPhraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePhraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPhrasesByBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookMangementSystemLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.Info;
            this.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookManagementToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.progressToolStripMenuItem,
            this.reviewsToolStripMenuItem,
            this.favoritePhrasesToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(521, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // bookManagementToolStripMenuItem
            // 
            this.bookManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.editBookToolStripMenuItem,
            this.deleteBookToolStripMenuItem,
            this.displayAllBooksToolStripMenuItem});
            this.bookManagementToolStripMenuItem.Name = "bookManagementToolStripMenuItem";
            this.bookManagementToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.bookManagementToolStripMenuItem.Text = "Book Management";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // editBookToolStripMenuItem
            // 
            this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            this.editBookToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.editBookToolStripMenuItem.Text = "Edit Book";
            this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
            // 
            // deleteBookToolStripMenuItem
            // 
            this.deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            this.deleteBookToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteBookToolStripMenuItem.Text = "Delete Book";
            this.deleteBookToolStripMenuItem.Click += new System.EventHandler(this.deleteBookToolStripMenuItem_Click);
            // 
            // displayAllBooksToolStripMenuItem
            // 
            this.displayAllBooksToolStripMenuItem.Name = "displayAllBooksToolStripMenuItem";
            this.displayAllBooksToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.displayAllBooksToolStripMenuItem.Text = "Display All Books";
            this.displayAllBooksToolStripMenuItem.Click += new System.EventHandler(this.displayAllBooksToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem1});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.searchToolStripMenuItem1.Text = "Search Book";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // progressToolStripMenuItem
            // 
            this.progressToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressByBookToolStripMenuItem});
            this.progressToolStripMenuItem.Name = "progressToolStripMenuItem";
            this.progressToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.progressToolStripMenuItem.Text = "Progress";
            // 
            // progressByBookToolStripMenuItem
            // 
            this.progressByBookToolStripMenuItem.Name = "progressByBookToolStripMenuItem";
            this.progressByBookToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.progressByBookToolStripMenuItem.Text = "Progress by Book";
            // 
            // reviewsToolStripMenuItem
            // 
            this.reviewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeReviewToolStripMenuItem});
            this.reviewsToolStripMenuItem.Name = "reviewsToolStripMenuItem";
            this.reviewsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.reviewsToolStripMenuItem.Text = "Reviews";
            // 
            // writeReviewToolStripMenuItem
            // 
            this.writeReviewToolStripMenuItem.Name = "writeReviewToolStripMenuItem";
            this.writeReviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.writeReviewToolStripMenuItem.Text = "Write Review";
            this.writeReviewToolStripMenuItem.Click += new System.EventHandler(this.writeReviewToolStripMenuItem_Click);
            // 
            // favoritePhrasesToolStripMenuItem
            // 
            this.favoritePhrasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPhraseToolStripMenuItem,
            this.editPhraseToolStripMenuItem,
            this.deletePhraseToolStripMenuItem,
            this.viewPhrasesByBookToolStripMenuItem});
            this.favoritePhrasesToolStripMenuItem.Name = "favoritePhrasesToolStripMenuItem";
            this.favoritePhrasesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.favoritePhrasesToolStripMenuItem.Text = "Favorite Phrases";
            // 
            // addPhraseToolStripMenuItem
            // 
            this.addPhraseToolStripMenuItem.Name = "addPhraseToolStripMenuItem";
            this.addPhraseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addPhraseToolStripMenuItem.Text = "Add Phrase";
            // 
            // editPhraseToolStripMenuItem
            // 
            this.editPhraseToolStripMenuItem.Name = "editPhraseToolStripMenuItem";
            this.editPhraseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.editPhraseToolStripMenuItem.Text = "Edit Phrase";
            // 
            // deletePhraseToolStripMenuItem
            // 
            this.deletePhraseToolStripMenuItem.Name = "deletePhraseToolStripMenuItem";
            this.deletePhraseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.deletePhraseToolStripMenuItem.Text = "Delete Phrase";
            // 
            // viewPhrasesByBookToolStripMenuItem
            // 
            this.viewPhrasesByBookToolStripMenuItem.Name = "viewPhrasesByBookToolStripMenuItem";
            this.viewPhrasesByBookToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.viewPhrasesByBookToolStripMenuItem.Text = "View Phrases by Book";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.userInformationToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            // 
            // userInformationToolStripMenuItem
            // 
            this.userInformationToolStripMenuItem.Name = "userInformationToolStripMenuItem";
            this.userInformationToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.userInformationToolStripMenuItem.Text = "User Information";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // BookMangementSystemLabel
            // 
            this.BookMangementSystemLabel.AutoSize = true;
            this.BookMangementSystemLabel.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookMangementSystemLabel.Location = new System.Drawing.Point(78, 67);
            this.BookMangementSystemLabel.Name = "BookMangementSystemLabel";
            this.BookMangementSystemLabel.Size = new System.Drawing.Size(362, 33);
            this.BookMangementSystemLabel.TabIndex = 1;
            this.BookMangementSystemLabel.Text = "Book Mangement System";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(211, 400);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(78, 13);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "Version 1.0.0.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(196, 427);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(108, 13);
            this.AuthorLabel.TabIndex = 3;
            this.AuthorLabel.Text = "Author: Jorge Monraz";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.SpringGreen;
            this.textBox1.Location = new System.Drawing.Point(48, 134);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(432, 237);
            this.textBox1.TabIndex = 4;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.WordWrap = false;
            // 
            // LibraryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 471);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.BookMangementSystemLabel);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LibraryManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryManagement";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem bookManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritePhrasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem progressByBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeReviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPhraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPhraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePhraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPhrasesByBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.Label BookMangementSystemLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}