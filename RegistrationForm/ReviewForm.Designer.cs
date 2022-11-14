namespace RegistrationForm
{
    partial class ReviewForm
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
            this.reviewTextbox = new System.Windows.Forms.TextBox();
            this.booksListbox = new System.Windows.Forms.ListBox();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(46, 23);
            this.BackButton.TabIndex = 31;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // reviewTextbox
            // 
            this.reviewTextbox.Location = new System.Drawing.Point(295, 12);
            this.reviewTextbox.Multiline = true;
            this.reviewTextbox.Name = "reviewTextbox";
            this.reviewTextbox.Size = new System.Drawing.Size(330, 361);
            this.reviewTextbox.TabIndex = 32;
            // 
            // booksListbox
            // 
            this.booksListbox.FormattingEnabled = true;
            this.booksListbox.Location = new System.Drawing.Point(12, 83);
            this.booksListbox.Name = "booksListbox";
            this.booksListbox.Size = new System.Drawing.Size(257, 290);
            this.booksListbox.TabIndex = 34;
            this.booksListbox.SelectedIndexChanged += new System.EventHandler(this.booksListbox_SelectedIndexChanged);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(12, 46);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(257, 20);
            this.searchTextbox.TabIndex = 33;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(342, 402);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(230, 23);
            this.saveButton.TabIndex = 35;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(38, 402);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(191, 23);
            this.writeButton.TabIndex = 36;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.booksListbox);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.reviewTextbox);
            this.Controls.Add(this.BackButton);
            this.Name = "ReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReviewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox reviewTextbox;
        private System.Windows.Forms.ListBox booksListbox;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button writeButton;
    }
}