namespace Eshop
{
    public class Admin : Users
    {
        public Admin(UserEnum userType, string userName, string userPassword) : base(userType, userName, userPassword)
        {

        }
    }
}
