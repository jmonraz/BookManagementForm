using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm
{
    public class Book
    {
        public string mTitle { get; private set; }
        public string mAuthor { get; private set; }
        public string mGenre { get; private set; }
        public string mPages { get; private set; }
        public string mCurrentPage { get; private set; }
        public bool mBookExists = false;

        public static readonly List<Book> mBooks = new List<Book>();

        public static Book AddBook(string _title, string _author, string _genre, string _pages, string _currPage)
        {
            Book book = new Book();
            if(mBooks.Count == 0)
            {
                book.mTitle = _title;
                book.mAuthor = _author;
                book.mGenre = _genre;
                book.mPages = _pages;
                book.mCurrentPage = _currPage;

                mBooks.Add(book);
                book.mBookExists = false;
                return book;
            }
            for(int i = 0; i < mBooks.Count; i++)
            {
                if(mBooks[i].mTitle == _title)
                {
                    book.mBookExists = true;
                }
            }
            if(!book.mBookExists)
            {
                book.mTitle = _title;
                book.mAuthor = _author;
                book.mGenre = _genre;
                book.mPages = _pages;
                book.mCurrentPage = _currPage;

                mBooks.Add(new Book { mTitle = _title, mAuthor = _author, mGenre = _genre, mPages = _pages, mCurrentPage = _currPage });
                book.mBookExists = false;
            }
            return book;
        }
        
        public static void DeleteBook(int _index)
        {
            mBooks.RemoveAt(_index);
        }
        public static void EditBook(string _title,string _author, string _genre, string _pages, int _index)
        {
            mBooks[_index].mTitle = _title;
            mBooks[_index].mAuthor = _author;
            mBooks[_index].mGenre = _genre;
            mBooks[_index].mPages = _pages;
        }
        public static void EditBook(string _currentPage, int _index)
        {
            mBooks[_index].mCurrentPage = _currentPage;
        }
    }
}
