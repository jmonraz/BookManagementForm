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
    public partial class ProgressByBookForm : Form
    {
        BookListForm blf = new BookListForm();
        
        string mPages = string.Empty;
        string mCurrentPage = string.Empty;

        private bool mBookEmpty = true;
        int mBookIndex = 0;
        public ProgressByBookForm()
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
            saveButton.Enabled = true;
            currentPageTextbox.Clear();
            mBookIndex = 0;
            foreach (Book book in Book.mBooks)
            {
                if (blf.mTitle == book.mTitle)
                {
                    mPages = book.mPages;
                    titleTextbox.Text = book.mTitle;
                    mCurrentPage = book.mCurrentPage;
                    currentPageTextbox.Text = book.mCurrentPage;
                    mBookEmpty = false;
                    break;
                }
                mBookIndex++;
            }

            CalculateProgress();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(mBookEmpty)
            {
                saveButton.Enabled = false;
            }
            else
            {
                mCurrentPage = currentPageTextbox.Text;
                Book.EditBook(mCurrentPage, mBookIndex);
                FileFunctions.UpdateBooks();
                MessageBox.Show("Saved");
                LoadBook();
            }
        }

        private void CalculateProgress()
        {
            if (mBookEmpty) return;

            int totalPages = int.Parse(mPages);
            int currentPage = int.Parse(mCurrentPage);

            float mpercentage = ((float)(currentPage) / (float)(totalPages) * 100);
            int percentage = (int)Math.Round(mpercentage, 0);
            totalPagesLabel.Text = "Page " + currentPage + " of " + totalPages;

            progressBar.Value = 0;
            progressBar.Maximum = totalPages;
            progressBar.Value = currentPage;

            percentageLabel.Text = percentage.ToString() +"%";
        }
    }
}
