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
            // NOT FULLY IMPLEMENTED YET
            //this.BooksListbox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
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
            if (BooksListbox.SelectedIndex < 0) return;
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    // NOT FULLY IMPLEMENTED YET
        //    //e.DrawBackground();

        //    //Brush myBrush = Brushes.Black;

        //    //if(e.Index%2 == 0)
        //    //{
        //    //    myBrush = Brushes.Red;
        //    //}
        //    //else
        //    //{
        //    //    myBrush = Brushes.Green;
        //    //}


        //    //e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
        //    //e.DrawFocusRectangle();
        //}
    }
}
