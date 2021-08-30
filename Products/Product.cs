namespace Eshop
{
    public abstract class Product
    {
        public readonly int _id;
        public readonly string _name;
        public int _quantity;
        public int _price;

        public Product(int id, string name, int quantity, int price)
        {
            _id = id;
            _name = name;
            _quantity = quantity;
            _price = price;
        }

        //public int GetId()
        //{
        //    return _id;
        //}
    }
}
