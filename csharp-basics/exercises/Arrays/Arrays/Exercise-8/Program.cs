using System;
using System.Net.Mime;
using System.Text;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            string response;

            string[] words =
            {
                "butterfly", "architecture", "ignore", 
                "Water", "Weight", "Wetlands"
            };

            var rnd = new Random();

            var word = words[rnd.Next(0, words.Length)];

            var guessable = new string('_', word.Length);
            var misses = string.Empty;

            while (guessable.IndexOf('_') != -1)
            {
                if (misses.Length != 3)
                {
                    Console.WriteLine($"word: {guessable}");
                    Console.WriteLine($"misses: {misses}");
                    var input = Console.ReadKey();
                    var guess = input.KeyChar;
                    Console.WriteLine();
                    Console.WriteLine($"Guess: {guess}");

                    if (WordCountains(word, guess))
                    {
                        for (var i = 0; i < word.Length; i++)
                        {
                            if (word.ToLower()[i] == guess)
                            {
                                var sb = new StringBuilder(guessable);
                                sb[i] = word[i];
                                guessable = sb.ToString();
                            }
                        }
                    }
                    else
                    {
                        misses += guess;
                    }
                }
                else
                { 
                    Console.WriteLine("Attempts are wasted!");
                    Console.WriteLine("Word: " + word);
                    Console.WriteLine("Misses: " + misses);
                    break;
                }
            }

            if (guessable == word)
            {
                Console.WriteLine("Word: " + word);
                Console.WriteLine("Misses: " + misses);
                Console.WriteLine("YOU GOT IT!");
            }

            Console.WriteLine("Would you like play again (Y/N)?");
            response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y")
            { 
                Run();
            }
            else if (response == "N")
            {
                Console.WriteLine("Good buy!");
                Console.ReadKey();
            }
        }

        public static bool WordCountains(string word, char guess)
        {
            return word.ToLower().IndexOf(guess) > -1;
        }
    }
}
