using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word: ");
            string firstWord = Console.ReadLine();

            Console.WriteLine("Enter second word: ");
            string secondWord = Console.ReadLine();

            int fistLineLength = firstWord.Length;
            int secondLineLength = secondWord.Length;
            int allLineLength = 30;

            int dotCount = 30 - (fistLineLength + secondLineLength);
            string readyText = "";
            string dot = ".";

            for (int i = 0; i < dotCount; i++)
            {
                readyText += dot;
            }

            Console.WriteLine(firstWord + readyText + secondWord);
        }
    }
}
