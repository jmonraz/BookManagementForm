using System;
using System.CodeDom;
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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Book book = Book.AddBook(TitleTextbox.Text, AuthorTextbox.Text, GenreTextbox.Text, PagesTextbox.Text, "1");
            if(TitleTextbox.Text.Length == 0 || TitleTextbox.Text.Trim().Length == 0)
            {
                MessageBox.Show("No book title provided");
                TitleTextbox.Clear();
                AuthorTextbox.Clear();
                GenreTextbox.Clear();
                PagesTextbox.Clear();
            }
            else if(book.mBookExists)
            {
                MessageBox.Show("Book already exsits");
                TitleTextbox.Clear();
                AuthorTextbox.Clear();
                GenreTextbox.Clear();
                PagesTextbox.Clear();
            }
            else if(!book.mBookExists)
            {
                FileFunctions.WriteBook(book);
                MessageBox.Show($"{book.mTitle} added to library");
                this.Close();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
