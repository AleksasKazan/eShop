using System;

namespace Eshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Eshop eshop = new Eshop();

            ConsoleKeyInfo cki;
            ConsoleKeyInfo cki2;

            Console.WriteLine("Welcome to Eshop\n");
            Console.WriteLine("Customers press - 1");
            Console.WriteLine("Owner     press - 2");
            Console.WriteLine("Press ESC to End\n");
            do
            {
                cki = Console.ReadKey();
                var _userInputName = "";
                var _userInputPassword = "";
                var _money = 0;
                switch (cki.Key)
                {
                    case (ConsoleKey)UserEnum.Customer:
                        Console.Write("Enter User name: ");
                        _userInputName = Console.ReadLine();

                        Console.Write("Ener User password: ");
                        _userInputPassword = Console.ReadLine();

                        eshop.Login(_userInputName, _userInputPassword);

                        Console.WriteLine("Press L - for the available products list");
                        Console.WriteLine("Press B - for your Balance info");
                        Console.WriteLine("Press T - to Top Up your Balance");
                        Console.WriteLine("Press Enter - to Start shoping");

                        cki2 = Console.ReadKey();

                        switch (cki2.Key)
                        {
                            case ConsoleKey.L:
                                Console.WriteLine(eshop.ToString());
                                break;
                            case ConsoleKey.B:
                                eshop.ShowBalance(_userInputName);
                                break;
                            case ConsoleKey.T:
                                Console.Write($"Top Up your balance: ");
                                eshop.ShowBalance(_userInputName);
                                _money = Convert.ToInt32(Console.ReadLine());
                                eshop.TopUp(_userInputName, _money);
                                break;
                            case ConsoleKey.Enter:
                                while (true)
                                {
                                    var _back = 0;
                                    Console.WriteLine(eshop.ToString());
                                    Console.WriteLine("\nPlease enter Product Id:");
                                    var productId = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine($"\nEnter Product quantity (available: ):");
                                    var inputQuantity = Convert.ToInt32(Console.ReadLine());
                                    eshop.AddToBasket(productId, inputQuantity);
                                    eshop.ShowBasket();
                                    Console.WriteLine(eshop.ToString());

                                    Console.WriteLine("To add more products enter - 1");
                                    _back = Convert.ToInt32(Console.ReadLine());

                                    eshop.CheckOut();
                                    Console.WriteLine(eshop.ToString());
                                }


                                //break;
                        }
                        break;
                                //default:
                                //    Console.WriteLine("Unknown Product");
                    case (ConsoleKey)UserEnum.Admin:
                        Console.Write("Enter User name: ");
                        _userInputName = Console.ReadLine();

                        Console.Write("Ener User password: ");
                        _userInputPassword = Console.ReadLine();
                        eshop.Login(_userInputName, _userInputPassword);
                        int _backToMenu;
                        while (true)
                        {
                            Console.WriteLine(eshop.ToString());
                            Console.WriteLine("Please enter Product Id to Add quantity:");
                            var _productId = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter quantity: ");
                            var _inputQuantity = Convert.ToInt32(Console.ReadLine());

                            eshop.Add(_productId, _inputQuantity);
                            Console.WriteLine(eshop.ToString());
                            Console.WriteLine("To add more products enter - 1");
                            _backToMenu = Convert.ToInt32(Console.ReadLine());
                            //break;
                        }

                        //default:
                        //    Console.WriteLine("Unknown User");
                        //break;
                                    }
            } while (cki.Key != ConsoleKey.Escape) ;
            Console.WriteLine("Thank you for shoping");
        }
    }
}
