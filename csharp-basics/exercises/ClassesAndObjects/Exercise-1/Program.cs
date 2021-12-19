using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var logitech = new Product("Logitech mouse", 70.00d, 14);
            var iphone = new Product("Phone 5s", 999.99d, 3);
            var epson = new Product("Epson EB-U05", 440.46d, 1);

            logitech.PrintProduct();
            epson.PrintProduct();
            iphone.PrintProduct();

            logitech.ChangePrice(115d);
            epson.ChangeQuantity(13);
            iphone.ChangeName("iPhone-11");

            Console.WriteLine();

            logitech.PrintProduct();
            epson.PrintProduct();
            iphone.PrintProduct();

            Console.ReadKey();
        }
    }
}
