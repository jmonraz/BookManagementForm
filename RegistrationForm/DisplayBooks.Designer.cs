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
            this.SuspendLayout();
            // 
            // BooksListbox
            // 
            this.BooksListbox.FormattingEnabled = true;
            this.BooksListbox.Location = new System.Drawing.Point(31, 26);
            this.BooksListbox.Name = "BooksListbox";
            this.BooksListbox.Size = new System.Drawing.Size(267, 355);
            this.BooksListbox.TabIndex = 0;
            // 
            // DisplayBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 420);
            this.Controls.Add(this.BooksListbox);
            this.Name = "DisplayBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayBooks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BooksListbox;
    }
}