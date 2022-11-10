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
        public string mName { get; private set; }
        public string mAge { get; private set; }
        public string mUserName {get;private set; }
        public string mPassword { get; private set; }
        public bool mUserExists = false;

        public static readonly List<User> mUsers = new List<User>();

        public static User AddUser(string _name, string _age, string _userName, string _password)
        {
            User user = new User();
            if(mUsers.Count == 0)
            {
                user.mName = _name;
                user.mAge = _age;
                user.mUserName = _userName;
                user.mPassword = _password;

                mUsers.Add(user);
                user.mUserExists = false;
                return user;
            }
            for(int i = 0; i < mUsers.Count; i++)
            {
                if(_userName == mUsers[i].mUserName)
                {
                    user.mUserExists = true;
                }
            }
            if(!user.mUserExists)
            {
                user.mName = _name;
                user.mAge = _age;
                user.mUserName = _userName;
                user.mPassword = _password;

                mUsers.Add(new User { mName = _name, mAge = _age, mUserName = _userName, mPassword = _password });
                user.mUserExists = false;
            }

            return user;
        }
    }
}
