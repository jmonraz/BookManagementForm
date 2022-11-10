using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationForm;

namespace RegistrationForm
{
    public class User
    {
        private string mName { get; set; }
        private string mAge { get; set; }
        private string mUserName { get; set; }
        private string mPassword { get; set; }

        protected List<User> mUsers = new List<User>();

        public List<User> AddUser(string _name, string _age, string _userName, string _password)
        {
            User user = new User();

            user.mName = _name;
            user.mAge = _age;
            user.mUserName = _userName;
            user.mPassword = _password;

            mUsers.Add(user);

            return mUsers;
        }
    }
}
