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
    public partial class ReviewForm : Form
    {
        string currTitle = string.Empty;
        string reviewString = string.Empty;
        public ReviewForm()
        {
            InitializeComponent();
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            booksListbox.Items.Clear();
            foreach (Book book in Book.mBooks)
            {
                if (book.mTitle.Contains(searchTextbox.Text))
                {
                    booksListbox.Items.Add(book.mTitle);
                }
            }
        }

        private void booksListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (booksListbox.SelectedIndex < 0)
                return;
            
                currTitle = booksListbox.SelectedItem.ToString();
            if (currTitle != string.Empty)
            {
                reviewString = FileFunctions.ReadReview(currTitle);
                reviewTextbox.Text = reviewString;
            }
            else
            {
                MessageBox.Show("No book selected");
            }

        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(reviewString != string.Empty)
            {
                reviewString = reviewTextbox.Text;
                FileFunctions.WriteReview(reviewString, currTitle);
                MessageBox.Show("Review Saved");
            }
            else
            {
                MessageBox.Show("No book selected");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchTextbox_Click(object sender, EventArgs e)
        {
            searchTextbox.Clear();
        }
    }
}
