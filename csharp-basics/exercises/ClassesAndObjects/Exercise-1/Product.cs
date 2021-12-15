using System;

namespace Exercise_1
{
    public class Product
    {
        private string _name;
        private int _amount;
        private double _price;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _amount = amountAtStart;
            _price = priceAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, {_price} EUR, {_amount} units");
        }

        public void ChangePrice(double price)
        {
            _price = price;
        }

        public void ChangeQuantity(int amount)
        {
            _amount = amount;
        }

        public void ChangeName(string name)
        {
            _name = name;
        }
    }
}
