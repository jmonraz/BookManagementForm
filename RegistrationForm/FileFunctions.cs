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
        static string mReviewFile = @".\";
        static string mPhrases = @".\";
        
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
        public static void WriteReview(string _review, string _title)
        {
            string review = mReviewFile + _title + ".txt";
            StreamWriter wr = new StreamWriter(review);
            wr.Flush();
            wr.Close();

            using(StreamWriter w = File.AppendText(review))
            {
                    w.Write(_review);
            }
        }

        public static string ReadReview(string _title)
        {
            string review = mReviewFile + _title + ".txt";

            
            string reviewString = string.Empty;
            if(!File.Exists(review))
            {
                using(StreamWriter w = File.AppendText(review))
                {
                    w.Write("Type here...");
                }
            }
            if(File.Exists(review))
            {
                StreamReader sr = new StreamReader(review);
                string currLine;

                while ((currLine = sr.ReadLine()) != null)
                {
                    reviewString += currLine;
                }
                sr.Close();
            }

            return reviewString;

        }

        public static void UpdateBooks()
        {
            StreamWriter w = new StreamWriter(mBooksFile);

            w.Flush();
            w.Close();
            
            using (w = File.AppendText(mBooksFile))
            {
                foreach(Book book in Book.mBooks)
                {
                    w.WriteLine(book.mTitle);
                    w.WriteLine(book.mAuthor);
                    w.WriteLine(book.mGenre);
                    w.WriteLine(book.mPages);
                    w.WriteLine(book.mCurrentPage);
                }
            }
        }

        public static void WritePhrase( string _title, List<string> _phrase)
        {
            List<string> page = new List<string>();
            List<string> phrase = new List<string>();

            for(int i = 0; i < _phrase.Count; i++)
            {
                page.Add(_phrase[i]);
                i++;
                phrase.Add(_phrase[i]);
            }
            
            string phraseString = mReviewFile + _title + "phrases.txt";
            StreamWriter wr = new StreamWriter(phraseString);
            wr.Flush();
            wr.Close();

            using (StreamWriter w = File.AppendText(phraseString))
            {
                for(int i = 0; i <phrase.Count; i++)
                {
                    w.WriteLine(page[i]);
                    w.WriteLine(phrase[i]);
                }
            }
        }

        public static List<string> ReadPhrase(string _title)
        {
            string phrasesString = mReviewFile + _title + "phrases.txt";


            List<string> phrases = new List<string>();
            
            
            if (File.Exists(phrasesString))
            {
                StreamReader sr = new StreamReader(phrasesString);
                string currLine;

                while ((currLine = sr.ReadLine()) != null)
                {
                    phrases.Add(currLine);
                }
                sr.Close();
            }

            return phrases;

        }
    }
}
