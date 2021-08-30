using System;
using System.Collections.Generic;
namespace Eshop
{
    public class Basket : Product
    {
        public Basket(int id, string name, int quantity, int price) : base(id, name, quantity, price)
        {
        }
    }
}
