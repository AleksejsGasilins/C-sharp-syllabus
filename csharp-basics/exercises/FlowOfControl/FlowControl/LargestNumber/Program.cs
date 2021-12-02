using System;
using System.Collections.Generic;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Console.ReadLine();

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Console.ReadLine();

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Console.ReadLine();

            List<string> list = new List<string>();
            list.Add(input1);
            list.Add(input2);
            list.Add(input3);

            foreach (string allNumbers in list)
            {
                Console.WriteLine("Input the 1st number: " + list[0]);
                Console.WriteLine("Input the 2nd number: " + list[1]);
                Console.WriteLine("Input the 3rd number: " + list[2]);
                Console.ReadKey();
            }
        }
    }
}
