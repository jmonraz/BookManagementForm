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
        public string mName { get; set; }
        public string mAge { get; set; }
        public string mUserName { get; set; }
        public string mPassword { get; set; }

        public List<User> users = new List<User>();

        public void AddUser(string _name, string _age, string _userName, string _password)
        {
            User user = new User();


            user.mName = _name;
            user.mAge = _age;
            user.mUserName = _userName;
            user.mPassword = _password;

            users.Add(user);
        }
    }
}
