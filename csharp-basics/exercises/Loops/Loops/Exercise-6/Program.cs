using System;

namespace Exercise_6
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the max number: ");
            string userNum = Console.ReadLine();
            int userNumInInt = Convert.ToInt32(userNum);

            for (int i = 1; i < userNumInInt + 1; i++)
            {
                if (i % 21 == 0)
                {
                    Console.WriteLine();
                }
                if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
