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
    public partial class DisplayBooks : Form
    {
        public DisplayBooks()
        {
            InitializeComponent();
            PopulateBooks();
        }

        public void PopulateBooks()
        {
            for(int i = 0; i < Book.mBooks.Count; i++)
            {
                BooksListbox.Items.Add(Book.mBooks[i].mTitle);
            }
        }

        private void BooksListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currTitle = BooksListbox.SelectedItem.ToString();

            TitleTextbox.Clear();
            AuthorTextbox.Clear();
            GenreTextbox.Clear();
            NumberOfPagesTextbox.Clear();

            foreach(Book book in Book.mBooks)
            {
                if(book.mTitle == currTitle)
                {
                    TitleTextbox.AppendText(book.mTitle);
                    AuthorTextbox.AppendText(book.mAuthor);
                    GenreTextbox.AppendText(book.mGenre);
                    NumberOfPagesTextbox.AppendText(book.mPages);
                }
            }

        }
    }
}
