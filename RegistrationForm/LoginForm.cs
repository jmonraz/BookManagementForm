using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistrationForm;

namespace RegistrationForm
{
    public partial class MyLoginForm : Form
    {
        
        public MyLoginForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyMainForm mf = new MyMainForm();
            mf.ShowDialog();
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User user = User.ReadUser(UsernameTextbox.Text, PasswordTextbox.Text);

            if(user.mUserExists)
            {
                MessageBox.Show($"Welcome {user.mName}!");
                this.Hide();
                LibraryManagementForm lf = new LibraryManagementForm();
                lf.ShowDialog();
                this.Close();
            }
            else if(!user.mUserExists)
            {
                MessageBox.Show("Username not found");
            }
        }
    }
}
