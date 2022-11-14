namespace RegistrationForm
{
    partial class ProgressByBookForm
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
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.totalPagesLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.LookupButton = new System.Windows.Forms.Button();
            this.currentPageTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(46, 23);
            this.BackButton.TabIndex = 32;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleLabel.Location = new System.Drawing.Point(118, 56);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(111, 22);
            this.bookTitleLabel.TabIndex = 34;
            this.bookTitleLabel.Text = "Book Title";
            // 
            // totalPagesLabel
            // 
            this.totalPagesLabel.AutoSize = true;
            this.totalPagesLabel.Location = new System.Drawing.Point(148, 297);
            this.totalPagesLabel.Name = "totalPagesLabel";
            this.totalPagesLabel.Size = new System.Drawing.Size(62, 13);
            this.totalPagesLabel.TabIndex = 35;
            this.totalPagesLabel.Text = "Page 0 of 0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(66, 271);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(235, 23);
            this.progressBar.TabIndex = 37;
            // 
            // LookupButton
            // 
            this.LookupButton.Location = new System.Drawing.Point(135, 12);
            this.LookupButton.Name = "LookupButton";
            this.LookupButton.Size = new System.Drawing.Size(75, 23);
            this.LookupButton.TabIndex = 38;
            this.LookupButton.Text = "Lookup";
            this.LookupButton.UseVisualStyleBackColor = true;
            this.LookupButton.Click += new System.EventHandler(this.LookupButton_Click);
            // 
            // currentPageTextbox
            // 
            this.currentPageTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPageTextbox.Location = new System.Drawing.Point(151, 187);
            this.currentPageTextbox.Name = "currentPageTextbox";
            this.currentPageTextbox.Size = new System.Drawing.Size(41, 20);
            this.currentPageTextbox.TabIndex = 39;
            this.currentPageTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Set Current Page";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(135, 228);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 41;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // titleTextbox
            // 
            this.titleTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.titleTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextbox.ForeColor = System.Drawing.Color.Maroon;
            this.titleTextbox.Location = new System.Drawing.Point(52, 101);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.ReadOnly = true;
            this.titleTextbox.Size = new System.Drawing.Size(262, 21);
            this.titleTextbox.TabIndex = 42;
            this.titleTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageLabel.Location = new System.Drawing.Point(307, 271);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(34, 20);
            this.percentageLabel.TabIndex = 43;
            this.percentageLabel.Text = "0%";
            // 
            // ProgressByBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 331);
            this.ControlBox = false;
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentPageTextbox);
            this.Controls.Add(this.LookupButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.totalPagesLabel);
            this.Controls.Add(this.bookTitleLabel);
            this.Controls.Add(this.BackButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressByBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProgressByBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.Label totalPagesLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button LookupButton;
        private System.Windows.Forms.TextBox currentPageTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.Label percentageLabel;
    }
}