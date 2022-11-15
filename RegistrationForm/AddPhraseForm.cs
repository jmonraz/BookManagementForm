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
    public partial class AddPhraseForm : Form
    {
        public struct Phrase
        {
            public string structPhrase;
            public string structPage;
        }

        private int mBookIndex = 0;
        private string mTitle = string.Empty;
        private string mPage = string.Empty;
        private string mPhrase = string.Empty;
        private bool mBookEmpty = true;

        private List<string> phrases = new List<string>();

        List<Phrase> mPhrases = new List<Phrase>();

        BookListForm blf = new BookListForm();

        public AddPhraseForm()
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
            addButton.Enabled = true;
            deleteButton.Enabled = true;
            
            TitleTextbox.Clear();

            mBookIndex = 0;
            foreach (Book book in Book.mBooks)
            {
                if (blf.mTitle == book.mTitle)
                {
                    TitleTextbox.Text = book.mTitle;
                    mTitle = book.mTitle;
                    mBookEmpty = false;
                    break;
                }
                mBookIndex++;
            }
            PopulateList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            phraseTextbook.Clear();
            pageTextbox.Clear();
            mPhrase = string.Empty;
            mPage = string.Empty;
            bookListbox.SelectedIndex = -1;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            phraseTextbook.Clear();
            pageTextbox.Clear();
            List<string> newPhrases = new List<string>();
            int index = bookListbox.SelectedIndex;
            mPhrases.RemoveAt(index);
            for(int i = 0; i < mPhrases.Count; i++)
            {
                newPhrases.Add(mPhrases[i].structPage);
                newPhrases.Add(mPhrases[i].structPhrase);
            }
            FileFunctions.WritePhrase(mTitle, newPhrases);
            LoadBook();
        }

        private void PopulateList()
        {
            bookListbox.Items.Clear();
            phrases.Clear();
            mPhrases.Clear();
            phrases = FileFunctions.ReadPhrase(mTitle);

            for(int i = 0; i < phrases.Count; i++)
            {
                mPhrases.Add(new Phrase { structPage = phrases[i], structPhrase = phrases[i + 1] });
                i++;
                
            }

            for(int i = 0; i < mPhrases.Count; i++)
            {
                bookListbox.Items.Add(mPhrases[i].structPhrase);
            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(mBookEmpty)
            {
                saveButton.Enabled = false;
            }
            else
            {
                
                mPage = pageTextbox.Text;
                phrases.Add(mPage);
                mPhrase = phraseTextbook.Text;
                phrases.Add(mPhrase);

                FileFunctions.WritePhrase(mTitle, phrases);
                MessageBox.Show("Saved");
            }

            LoadBook();
        }

        private void bookListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookListbox.SelectedIndex < 0) return;

            string currPhrase = bookListbox.SelectedItem.ToString();
            for(int i = 0; i < mPhrases.Count; i++)
            {
                if(currPhrase == mPhrases[i].structPhrase)
                {
                    phraseTextbook.Text = mPhrases[i].structPhrase;
                    pageTextbox.Text = mPhrases[i].structPage;
                }
            }
        }
    }
}
