using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RegistrationForm
{
    public static class FileFunctions
    {
        static string mUsersFile = @".\users.txt";
        static string mBooksFile = @".\books.txt";
        
        public static void LoadUsers()
        {
            string name = string.Empty;
            string age = string.Empty;
            string userName = string.Empty;
            string password = string.Empty;
            // Will read the file and add users to the mUsers list in User class
            if (File.Exists(mUsersFile))
            {
                StreamReader textLines = new StreamReader(mUsersFile);
                string currLine;

                if (User.mUsers.Count == 0)
                {
                    int mod = 1;
                    
                    while ((currLine = textLines.ReadLine()) != null)
                    {
                        if (mod % 4 == 1)
                        {
                            name = currLine;
                            mod++;
                        }
                        else if (mod % 4 == 2)
                        {
                            age = currLine;
                            mod++;
                        }
                        else if (mod % 4 == 3)
                        {
                            userName = currLine;
                            mod++;
                        }
                        else if (mod % 4 == 0)
                        {
                            password = currLine;
                            User.AddUser(name, age, userName, password);
                            mod++;
                        }
                    }
                }

                textLines.Close();
            }
        }
        public static void LoadBooks()
        {
            string title = String.Empty;
            string author = String.Empty;
            string genre = String.Empty;
            string pages = String.Empty;
            string currentPage = String.Empty;
            if(File.Exists(mBooksFile))
            {
                StreamReader sr = new StreamReader(mBooksFile);
                string currLine;

                if(Book.mBooks.Count == 0)
                {
                    int mod = 1;
                    while((currLine = sr.ReadLine()) != null)
                    {
                        if(mod%5 == 1)
                        {
                            title = currLine;
                            mod++;
                        }
                        else if(mod%5 == 2)
                        {
                            author = currLine;
                            mod++;
                        }
                        else if(mod%5 == 3)
                        {
                            genre = currLine;
                            mod++;
                        }
                        else if(mod%5 == 4)
                        {
                            pages = currLine;
                            mod++;
                        }
                        else if(mod%5 == 0)
                        {
                            currentPage = currLine;
                            Book.AddBook(title, author, genre, pages, currentPage);
                            mod++;
                        }
                    }
                    sr.Close();
                }
            }
        }
        public static void WriteUser(User _user)
        {
                using(StreamWriter w = File.AppendText(mUsersFile))
                {
                    for(int i = 0; i < 1; i++)
                    {
                        w.WriteLine(_user.mName);
                        w.WriteLine(_user.mAge);
                        w.WriteLine(_user.mUserName);
                        w.WriteLine(_user.mPassword);
                    }
               }
           
        }
        public static void WriteBook(Book _book)
        {
            using(StreamWriter w = File.AppendText(mBooksFile))
            {
                for(int i = 0; i < 1; i++)
                {
                    w.WriteLine(_book.mTitle);
                    w.WriteLine(_book.mAuthor);
                    w.WriteLine(_book.mGenre);
                    w.WriteLine(_book.mPages);
                    w.WriteLine(_book.mCurrentPage);
                }
            }
        }
    }
}
