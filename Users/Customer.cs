using System;
namespace Eshop
{
    public class Customer : Users
    {
        //public int _userBalance;
        public Customer(UserEnum userType, string userName, string userPassword, int userBalance) : base(userType, userName, userPassword)
        {
            _userBalance = userBalance;
        }

        //public int GetBalance()
        //{
        //    return _userBalance;
        //}
    }

    
}
