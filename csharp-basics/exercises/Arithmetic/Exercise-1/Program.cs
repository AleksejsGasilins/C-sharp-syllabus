using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WriteNum(15, 30));
            Console.WriteLine(WriteNum(5, 20));
            Console.WriteLine(WriteNum(7, 0));
            Console.WriteLine(WriteNum(30, 15));
            Console.WriteLine(WriteNum(7, 8));
        }

        public static bool WriteNum(int x, int y)
        {
            return x == 15 || y == 15 || x + y == 15 || x - y == 15 || y - x == 15;
        }
    }
}
