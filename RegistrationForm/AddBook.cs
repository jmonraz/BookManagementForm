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

            if(book.mBookExists)
            {
                MessageBox.Show("Book already exsits");
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
