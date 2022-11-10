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
            // Will read the file and add users to the mUsers list in User class
        }
        public static bool WriteUsers(List<User> _users)
        {
            bool userExists = false;

            return userExists;
        }
    }
}
