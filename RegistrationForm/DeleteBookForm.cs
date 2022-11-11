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
    public partial class DeleteBookForm : Form
    {
        BookListForm blf = new BookListForm();
        private bool mBookEmpty = true;
        int mBookIndex = 0;
        public DeleteBookForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            blf.Close();
            this.Close();
        }

        private void LookupButton_Click(object sender, EventArgs e)
        {
            blf.ShowDialog();
            LoadBook();
        }

        private void LoadBook()
        {
            DeleteButton.Enabled = true;
            TitleTextbox.Clear();
            AuthorTextbox.Clear();
            GenreTextbox.Clear();
            PagesTextbox.Clear();

            foreach (Book book in Book.mBooks)
            {
                if (blf.mTitle == book.mTitle)
                {
                    TitleTextbox.Text = book.mTitle;
                    AuthorTextbox.Text = book.mAuthor;
                    GenreTextbox.Text = book.mGenre;
                    PagesTextbox.Text = book.mPages;
                    mBookEmpty = false;
                    break;
                }
                mBookIndex++;
            }


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(mBookEmpty)
            {
                DeleteButton.Enabled = false;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure?","title", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if(dr == DialogResult.Yes)
                {
                    Book.DeleteBook(mBookIndex);
                    FileFunctions.UpdateBooks();
                    MessageBox.Show("Book deleted");
                    blf.Close();
                    this.Close();
                }
            }
        }
    }
}
