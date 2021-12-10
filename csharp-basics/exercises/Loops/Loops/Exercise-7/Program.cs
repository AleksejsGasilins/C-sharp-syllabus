using System;

namespace Exercise_7
{
    class Piglet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            Console.WriteLine("Do you wanna start game? Press any button!");
            Console.ReadKey();

            Random rnd = new Random();
            int getRndNum = rnd.Next(1, 6);
            int firstRndNum = rnd.Next(2, 6);

            Console.WriteLine("You rolled a " + firstRndNum + "!");
            Console.Write("Roll again? (Y/N)");
            string userChoice = Console.ReadLine();

            int userScore = 0;

            for (int i = getRndNum; i != 1; i++)
            {
                
            }
        }
    }
}
