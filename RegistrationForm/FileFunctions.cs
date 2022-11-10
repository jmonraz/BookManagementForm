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
    }
}
