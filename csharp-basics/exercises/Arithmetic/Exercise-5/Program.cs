using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("I'm thinking of a number between " + min + "-" + max + ". Try to guess it.");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(">" + guess);

                    if (guess > number)
                    {
                        Console.WriteLine("Sorry, you are too high.");
                    } 
                    else if (guess < number)
                    {
                        Console.WriteLine("Sorry, you are too low.");
                    }

                    guesses++;
                }

                Console.WriteLine("Number: " + number);
                Console.WriteLine("You guessed it!  What are the odds?!?");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N)? ");
                response = Console.ReadLine();
                response = response.ToUpper();

                playAgain = response == "Y" ? true : false;
            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }
    }
}
