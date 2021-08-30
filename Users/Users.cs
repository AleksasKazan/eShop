using System;
using System.Collections.Generic;

namespace Eshop
{
    public abstract class Users
    {
        public readonly UserEnum _userType;
        public string _userName;
        public string _userPassword;
        public int _userBalance;

        public List<Users> _users = new List<Users>();
        public Users(UserEnum userType, string userName, string userPassword)
        {
            _userType = userType;
            _userName = userName;
            _userPassword = userPassword;
        }
    }
}
