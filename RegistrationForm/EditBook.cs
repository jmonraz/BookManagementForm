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
    public partial class EditBook : Form
    {
        string mTitle = string.Empty;
        string mAuthor = string.Empty;
        string mGenre = string.Empty;
        string mPages = string.Empty;

        private bool bookEmpty = true;
        int bookIndex = 0;
        BookListForm blf = new BookListForm();
        public EditBook()
        {
            InitializeComponent();
            
        }

        private void LookupButton_Click(object sender, EventArgs e)
        {
            blf.ShowDialog();
            LoadBook();
        }

        private void LoadBook()
        {
            SaveButton.Enabled = true;
            TitleTextbox.Clear();
            AuthorTextbox.Clear();
            GenreTextbox.Clear();
            PagesTextbox.Clear();

            foreach(Book book in Book.mBooks)
            {
                if(blf.mTitle == book.mTitle)
                {
                    TitleTextbox.Text = book.mTitle;
                    AuthorTextbox.Text = book.mAuthor;
                    GenreTextbox.Text = book.mGenre;
                    PagesTextbox.Text = book.mPages;
                    bookEmpty = false;
                    break;
                }
                bookIndex++;
            }

            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(bookEmpty)
            {
                SaveButton.Enabled = false;
            }
            else
            {
                mTitle = TitleTextbox.Text;
                mAuthor = AuthorTextbox.Text;
                mGenre = GenreTextbox.Text;
                mPages = PagesTextbox.Text;
                Book.EditBook(mTitle, mAuthor, mGenre, mPages, bookIndex);
                MessageBox.Show("Book saved");
                blf.Close();
                this.Close();
            }
            
        }
    }
}
