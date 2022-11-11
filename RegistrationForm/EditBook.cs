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
                }
            }
        }
    }
}
