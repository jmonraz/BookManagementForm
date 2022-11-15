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
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadUsers()
        {
            for (int i = 0; i < User.mUsers.Count; i++)
            {
                usersDatagrid.Rows.Add(User.mUsers[i].mName, User.mUsers[i].mAge, User.mUsers[i].mUserName, User.mUsers[i].mPassword);
            }
        }
    }
}
