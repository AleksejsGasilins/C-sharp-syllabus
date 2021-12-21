using System;
using System.Collections.Generic;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> userNums = new List<int[]>();
            List<int> userNums2 = new List<int>();

            Console.WriteLine("Enter your number: ");
            string userInput = Console.ReadLine();
            userNums.Add(GetIntArray(Convert.ToInt32(userInput)));
            int sum = 0;

            for (int i = 0; i < userNums.Count; i++)
            {
                userNums2.Add(userNums[i] * Convert.ToInt32(Math.Pow(10, userNums.Count - i - 1)));
            }


            for (int i = 0; i < userNums.Count; i++)
            {
                sum += userNums[] ^ 2;
            }

            Console.WriteLine(sum);
        }

        public static int[] GetIntArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }
    }
}
