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
    public partial class BookListForm : Form
    {
        public string mTitle { get; private set; }
        public BookListForm()
        {
            InitializeComponent();
            PopulateList();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            mTitle = String.Empty;
            this.Close();
        }

        public void PopulateList()
        {
            foreach(Book book in Book.mBooks)
            {
                BookListbox.Items.Add(book.mTitle);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (BookListbox.SelectedIndex < 0) return;
            mTitle = BookListbox.SelectedItem.ToString();
            this.Close();
        }
    }
}
