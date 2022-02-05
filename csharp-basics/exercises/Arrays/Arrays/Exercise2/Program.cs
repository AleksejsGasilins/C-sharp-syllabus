using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {

        private static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());

            List<int> allUserNums = new List<int>();
            allUserNums.Add(minNumber);
            allUserNums.Add(maxNumber);

            for (int i = 0; i < allUserNums.Count; i++)
            {
                sum = minNumber + maxNumber;
            }

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}