using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eshop
{
    public class Eshop
    {       
        public List<Product> _catalog;
        public List<Users> _users;
        public List<Product> _baket;

        public Eshop()
        {
            _catalog = new List<Product>
            {
                new Sweets(1, "Sweets", 100, 5),
                new Book(2, "Book", 200, 7),
                new Cup(3, "Cup", 300, 8)
            };

            _users = new List<Users>
            {
                new Admin(UserEnum.Admin, "Alex", "admin"),
                new Customer(UserEnum.Customer, "User1", "user", 100),
                new Customer(UserEnum.Customer, "User2", "user", 20)
            };

            _baket = new List<Product>();

        }

        public void Login(string _userInputName, string _userInputPassword)
        {
            foreach (var user in _users)
            {
                if (user._userName != _userInputName)
                {
                    Console.WriteLine("Wrong User Name");
                    break;
                } else if (user._userPassword != _userInputPassword)
                {
                    Console.WriteLine("Wrong User Password");
                    break;
                }
            }
        }

        public void ShowBalance(string _userInputName)
        {
            foreach (var user in _users)
            {
                if (user._userName == _userInputName)
                {
                    Console.WriteLine($"\nYour balance: {user._userBalance}");
                }
            }
        }

        public void ShowBasket()
        {
            foreach (var item in _baket)
            {
                Console.WriteLine($"{item._id} {item._name} {item._quantity} {item._price}");
            }
        }

        public void TopUp(string _userInputName, int _money)
        {
            foreach (var user in _users)
            {
                if (user._userName == _userInputName)
                {
                    user._userBalance += _money;
                    Console.WriteLine($"\nYour balance: {user._userBalance}");
                }
            }
        }

        public void Add(int productId, int inputQuantity)
        {
            foreach (var product in _catalog)
            {
                //if (item.GetId() == productId)
                if (product._id == productId)
                {
                    product._quantity += inputQuantity;
                }
            }
        }

        public void AddToBasket(int productId, int inputQuantity)
        {
            _baket.
            foreach (var basketProduct in _catalog)
            {
                if (basketProduct._quantity >= inputQuantity && basketProduct._id == productId)
                {
                    basketProduct._quantity = inputQuantity;
                    _baket.Add(basketProduct);
                    //foreach (var item in _baket)
                    //{

                    //}
                }
                else
                {
                    Console.WriteLine("Not available quantity");
                    break;
                }
                Console.WriteLine($"Available: {basketProduct._quantity}");
                break;
            }
        }

        public void CheckOut()
        {
            foreach (var product in _catalog)
            {
                foreach (var user in _users)
                {
                    foreach (var item in _baket)
                    {
                        if (user._userBalance < item._quantity * product._price)
                        {
                            Console.WriteLine("Not eneught balance, press T to Top Up yout balance");
                            break;
                        }
                        else
                        {
                            product._quantity -= item._quantity;
                            user._userBalance -= item._quantity * product._price;
                        }
                    }
                    
                }
            }
            
            
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("\nHere is the Eshop products list: ");

            foreach (var item in _catalog)
            {
                if (item._quantity !=0)
                {
                    sb.AppendLine("Product Id: " + item._id + ", name: " + item._name + ", quantity: " + item._quantity + ", price: " + item._price.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
