using System;

namespace Exercise___10
{
    class NumberSquare
    {
        static void Main(string[] args)
        {
            Console.Write("Enter min number: ");
            var userMinNum = Console.ReadKey();

            Console.Write("\nEnter max number: ");
            var userMaxNum = Console.ReadKey();

            Console.WriteLine();

            int minNumToInt = СheckOnNumber(userMinNum);
            int maxBumToInt = СheckOnNumber(userMaxNum);
            string count = " ";

            for (int i = minNumToInt; i < maxBumToInt + 1; i++)
            {
                for (int j = i; j < maxBumToInt + 1; j++)
                {
                    Console.Write(j + " ");
                }

                for (int k = 1; k < i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }

        public static int СheckOnNumber(ConsoleKeyInfo UserInput)
        {
            int Bowl;

            if (char.IsDigit(UserInput.KeyChar))
            {
               return Bowl = int.Parse(UserInput.KeyChar.ToString());
            }
            else
            {
               return Bowl = -1;
            }
        }
    }
}
