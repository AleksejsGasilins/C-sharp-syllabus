using System;
using System.Collections.Generic;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> nameCount = new HashSet<string>();

            Console.Write("Enter some Name: ");
            var userName = Console.ReadLine();

            while (userName != "")
            {
                Console.Write("Enter some Name: ");
                userName = Console.ReadLine();

                nameCount.Add(userName);

            }
            
            Console.Write("Unique name list contains: ");
            Console.Write(string.Join(",", nameCount));
        }
    }
}
