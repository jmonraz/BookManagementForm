using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RegistrationForm
{
    public partial class MyMainForm : Form
    {
        Thread th;
        public MyMainForm()
        {
            FileFunctions.LoadUsers();
            InitializeComponent();
        }

        private void RegistrationNavigationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyRegistrationForm registrationForm = new MyRegistrationForm();
            registrationForm.ShowDialog();
            this.Close();
        }

       

        private void LoginNavigationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyLoginForm loginForm = new MyLoginForm();
            loginForm.ShowDialog();
            this.Close();
            
        }
    }
}
