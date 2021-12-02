using System;

namespace Exercise__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckOddEven(1));
            Console.WriteLine(CheckOddEven(2));
            Console.WriteLine(CheckOddEven(3));
            Console.WriteLine(CheckOddEven(4));
            Console.ReadKey();
            Console.WriteLine("Bye!");
        }

        public static string CheckOddEven(int x)
        {
            if (x % 2 == 0)
            {
                return "Even Number";
            }
            else
            {
                return "Odd Number";
            }
        }
    }
}
