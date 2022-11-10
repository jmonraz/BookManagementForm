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
            User user = new User();
            
            user.AddUser(NameTextbox.Text, AgeTextbox.Text, UsernameTextbox.Text, PasswordTextbox.Text);

            bool userExists = FileFunctions.WriteUser(user);

            if(userExists)
            {
                MessageBox.Show("User already exists");
            }
            else
            {
                MessageBox.Show("User successfully registered");
            }

        }
    }
}
