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

        private void displayAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBooks db = new DisplayBooks();

            if (Book.mBooks.Count == 0)
            {
                MessageBox.Show("No books in library!");
                db.Close();
            }
            else
            {
                db.ShowDialog();
            }
            
            
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBook eb = new EditBook();
            if (Book.mBooks.Count == 0)
            {
                MessageBox.Show("No books in library!");
                eb.Close();
            }
            else
            {
                eb.ShowDialog();
            }
        }
    }
}
