using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words =
            {
                "One", "Tow", "Three", "Four",
                "five", "six", "seven", "eight",
                "nine", "ten"
            };

            List<string> newWords = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                newWords.Add(words[i]);
            }

            Console.WriteLine(string.Join(",",newWords));

            newWords.Insert(4, "new 5th");

            Console.WriteLine(string.Join(",", newWords));

            newWords[newWords.Count - 1] = "last";

            Console.WriteLine(string.Join(",", newWords));

            newWords.Sort();

            Console.WriteLine(string.Join(",", newWords));

            int check = 0;

            for (int i = 0; i < newWords.Count; i++)
            {
                if (newWords[i] == "Foobar")
                {
                    check = 1;
                }
                else
                {
                    check = 2;
                    break;
                }
            }

            if (check == 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            for (int i = 0; i < newWords.Count; i++)
            {
                if (i == newWords.Count - 1)
                {
                    Console.Write($"{newWords[i]}.");
                }
                else
                {
                    Console.Write($"{newWords[i]}, ");
                }
            }

            Console.ReadKey();
        }
    }
}
