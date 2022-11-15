namespace RegistrationForm
{
    partial class MyMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMainForm));
            this.RegistrationNavigationButton = new System.Windows.Forms.Button();
            this.LoginNavigationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegistrationNavigationButton
            // 
            this.RegistrationNavigationButton.Location = new System.Drawing.Point(38, 37);
            this.RegistrationNavigationButton.Name = "RegistrationNavigationButton";
            this.RegistrationNavigationButton.Size = new System.Drawing.Size(115, 39);
            this.RegistrationNavigationButton.TabIndex = 0;
            this.RegistrationNavigationButton.Text = "Registration";
            this.RegistrationNavigationButton.UseVisualStyleBackColor = true;
            this.RegistrationNavigationButton.Click += new System.EventHandler(this.RegistrationNavigationButton_Click);
            // 
            // LoginNavigationButton
            // 
            this.LoginNavigationButton.Location = new System.Drawing.Point(182, 37);
            this.LoginNavigationButton.Name = "LoginNavigationButton";
            this.LoginNavigationButton.Size = new System.Drawing.Size(115, 39);
            this.LoginNavigationButton.TabIndex = 1;
            this.LoginNavigationButton.Text = "Login";
            this.LoginNavigationButton.UseVisualStyleBackColor = true;
            this.LoginNavigationButton.Click += new System.EventHandler(this.LoginNavigationButton_Click);
            // 
            // MyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 115);
            this.Controls.Add(this.LoginNavigationButton);
            this.Controls.Add(this.RegistrationNavigationButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegistrationNavigationButton;
        private System.Windows.Forms.Button LoginNavigationButton;
    }
}

