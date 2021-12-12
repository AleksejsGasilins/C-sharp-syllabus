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
            int firstRndNum = rnd.Next(2, 6);

            int userScore = 0;
            int loseScore = 0;

            Console.WriteLine("You rolled a " + firstRndNum + "!");
            userScore += firstRndNum;

            Console.Write("Roll again? (Y/N): ");
            string userChoice = Console.ReadLine();

            for (int i = firstRndNum; i != 1; i++)
            {
                int secondRndNum = rnd.Next(1, 6);

                if (secondRndNum != 1)
                {
                    if (userChoice == userChoice)
                    {
                        if (userChoice.ToLower() == "yes" || userChoice.ToLower() == "y")
                        {
                            Console.WriteLine("You rolled a " + secondRndNum + "!");
                            userScore += secondRndNum;

                            Console.Write("Roll again? (Y/N): ");
                            userChoice = Console.ReadLine();
                        }
                        else if (userChoice.ToLower() == "no" || userChoice.ToLower() == "n")
                        {
                            Console.WriteLine($"You got {userScore} points.");
                            break;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine($"You rolled a {secondRndNum}.");
                    Console.WriteLine($"You got {loseScore} points.");
                    break;
                }
            }
        }
    }
}
