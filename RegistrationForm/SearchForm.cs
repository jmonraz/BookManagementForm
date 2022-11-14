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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            booksListbox.Items.Clear();
            foreach(Book book in Book.mBooks)
            {
                if(radioButtonTitle.Checked)
                {
                    if (book.mTitle.Contains(searchTextbox.Text))
                    {
                        booksListbox.Items.Add(book.mTitle);
                    }
                }
                else if(radioButtonAuthor.Checked)
                {
                    if(book.mAuthor.Contains(searchTextbox.Text))
                    {
                        booksListbox.Items.Add(book.mTitle);
                    }
                }
                else if(radioButtonGenre.Checked)
                {
                    if(book.mGenre.Contains(searchTextbox.Text))
                    {
                        booksListbox.Items.Add(book.mTitle);
                    }
                }
                
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void booksListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currTitle = booksListbox.SelectedItem.ToString();

            TitleTextbox.Clear();
            AuthorTextbox.Clear();
            GenreTextbox.Clear();
            NumberOfPagesTextbox.Clear();

            foreach (Book book in Book.mBooks)
            {
                if (book.mTitle == currTitle)
                {
                    TitleTextbox.AppendText(book.mTitle);
                    AuthorTextbox.AppendText(book.mAuthor);
                    GenreTextbox.AppendText(book.mGenre);
                    NumberOfPagesTextbox.AppendText(book.mPages);
                }
            }
        }

        private void searchTextbox_Click(object sender, EventArgs e)
        {
            searchTextbox.Clear();
        }
    }
}
