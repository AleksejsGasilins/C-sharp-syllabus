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

            int minNumToInt = Сheck(userMinNum);
            int maxBumToInt = Сheck(userMaxNum);
            string count = " ";

            for (int i = minNumToInt; i != maxBumToInt + 1; i++)
            {
                Console.Write(i);
            }
        }

        public static int Сheck(ConsoleKeyInfo UserInput)
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
