using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class MyRegistrationForm : Form
    {
        
        public MyRegistrationForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            

            User user = User.AddUser(NameTextbox.Text, AgeTextbox.Text, UsernameTextbox.Text, PasswordTextbox.Text);

            

            if(user.mUserExists)
            {
                MessageBox.Show("User already exists");
            }
            else if(!user.mUserExists)
            {
                FileFunctions.WriteUser(user);
                MessageBox.Show("User successfully registered");
            }

        }
    }
}
