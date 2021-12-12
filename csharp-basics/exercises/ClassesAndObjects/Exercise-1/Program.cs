using System;

namespace Exercise_1
{
    class Product
    {
        public Product(string name, double priceAtStart, int amountAtStart)
        {
            PrintProduct("Logitech mouse", 70.00, 14);
        }

        public void PrintProduct(string name, double priceAtStart, int amountAtStart)
        {
            Console.Write($"{name}, price {priceAtStart} EUR, amount {amountAtStart} units");
        }
    }
}
