namespace RegistrationForm
{
    partial class AddPhraseForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.LookupButton = new System.Windows.Forms.Button();
            this.bookListbox = new System.Windows.Forms.ListBox();
            this.phraseTextbook = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.pageTextbox = new System.Windows.Forms.TextBox();
            this.pageLabel = new System.Windows.Forms.Label();
            this.TitleTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(46, 23);
            this.BackButton.TabIndex = 20;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LookupButton
            // 
            this.LookupButton.Location = new System.Drawing.Point(123, 12);
            this.LookupButton.Name = "LookupButton";
            this.LookupButton.Size = new System.Drawing.Size(75, 23);
            this.LookupButton.TabIndex = 21;
            this.LookupButton.Text = "Lookup";
            this.LookupButton.UseVisualStyleBackColor = true;
            this.LookupButton.Click += new System.EventHandler(this.LookupButton_Click);
            // 
            // bookListbox
            // 
            this.bookListbox.FormattingEnabled = true;
            this.bookListbox.Location = new System.Drawing.Point(13, 55);
            this.bookListbox.Name = "bookListbox";
            this.bookListbox.Size = new System.Drawing.Size(386, 355);
            this.bookListbox.TabIndex = 22;
            this.bookListbox.SelectedIndexChanged += new System.EventHandler(this.bookListbox_SelectedIndexChanged);
            // 
            // phraseTextbook
            // 
            this.phraseTextbook.Location = new System.Drawing.Point(447, 249);
            this.phraseTextbook.Multiline = true;
            this.phraseTextbook.Name = "phraseTextbook";
            this.phraseTextbook.Size = new System.Drawing.Size(307, 134);
            this.phraseTextbook.TabIndex = 23;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(447, 182);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(46, 46);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(499, 182);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(46, 46);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "-";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // pageTextbox
            // 
            this.pageTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTextbox.Location = new System.Drawing.Point(638, 198);
            this.pageTextbox.Name = "pageTextbox";
            this.pageTextbox.Size = new System.Drawing.Size(100, 24);
            this.pageTextbox.TabIndex = 27;
            this.pageTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageLabel.Location = new System.Drawing.Point(665, 179);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(40, 16);
            this.pageLabel.TabIndex = 28;
            this.pageLabel.Text = "Page";
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TitleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextbox.Location = new System.Drawing.Point(447, 134);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.ReadOnly = true;
            this.TitleTextbox.Size = new System.Drawing.Size(307, 24);
            this.TitleTextbox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Book Title";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(531, 389);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 23);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddPhraseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleTextbox);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.pageTextbox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.phraseTextbook);
            this.Controls.Add(this.bookListbox);
            this.Controls.Add(this.LookupButton);
            this.Controls.Add(this.BackButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPhraseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddPhraseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LookupButton;
        private System.Windows.Forms.ListBox bookListbox;
        private System.Windows.Forms.TextBox phraseTextbook;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox pageTextbox;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.TextBox TitleTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
    }
}