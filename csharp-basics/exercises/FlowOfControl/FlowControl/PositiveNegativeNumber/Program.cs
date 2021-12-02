using System;
using System.Collections.Generic;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            var input = Console.ReadLine();
            int userNum = Convert.ToInt32(input);

            if (userNum > 0)
            {
                Console.WriteLine("\nNumber is positive");
            } 
            else if (userNum < 0) 
            {
                Console.WriteLine("\nNumber is negative");
            } 
            else 
            {
                Console.WriteLine("\nNumber is zero");
            }

            Console.ReadKey();
        }
    }
}
