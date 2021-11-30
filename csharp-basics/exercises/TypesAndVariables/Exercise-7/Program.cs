using System;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string AmountOfSymbols;
            char[] UserText;
            int upper = 0;

            Console.WriteLine("Do you want to know the number of Uppercase letters in the text?");
            AmountOfSymbols = Console.ReadLine();
            UserText = AmountOfSymbols.ToCharArray();

            for (int i = 0; i < UserText.Length; i++)
            {
                if (char.IsUpper(UserText[i]))
                {
                    upper++;
                }
            }

            Console.WriteLine("Total Upper Case Letters: ");
            Console.WriteLine(upper.ToString());
        }
    }
}
