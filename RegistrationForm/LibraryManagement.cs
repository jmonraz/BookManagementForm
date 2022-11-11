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
    public partial class LibraryManagementForm : Form
    {
        public LibraryManagementForm()
        {
            FileFunctions.LoadBooks();
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook ab = new AddBook();

            ab.ShowDialog();
        }
    }
}
