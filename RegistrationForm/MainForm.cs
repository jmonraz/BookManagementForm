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
    public partial class MyMainForm : Form
    {
        
        public MyMainForm()
        {
            InitializeComponent();
        }

        private void RegistrationNavigationButton_Click(object sender, EventArgs e)
        {
            MyRegistrationForm registrationForm = new MyRegistrationForm();
            registrationForm.Show();
        }

        private void LoginNavigationButton_Click(object sender, EventArgs e)
        {
            MyLoginForm loginForm = new MyLoginForm();
            loginForm.Show();
            
        }
    }
}
