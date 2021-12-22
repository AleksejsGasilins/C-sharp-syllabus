using System;
using System.Collections.Generic;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> userChars = new List<char>();
            List<int> userNums = new List<int>();

            Console.WriteLine("Enter your number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            foreach (var _Char in UserIntToChar(userInput))
            {
                userChars.Add(_Char);
            }

            List<double> charInInt = new List<double>();

            do
            {
                int sum = 0;

                for (int i = 0; i < userChars.Count; i++)
                {

                    charInInt.Add(Convert.ToDouble(userChars[i] - '0'));

                    sum += Convert.ToInt32(Math.Pow(charInInt[i], 2));

                    if (i == userChars.Count - 1)
                    {
                        userNums.Add(sum);
                    }
                }

                userChars.Clear();
                charInInt.Clear();

                var zz = UserIntToChar(sum); 
                AddNewChar(zz, userChars);

                userNums.Clear();

            } while (userChars.Count != 1);

            if (userChars.Contains('1'))
            {
                Console.Write("Heppy");
            }
            else
            {
                Console.Write("Not heppy");
            }

        }

        public static char[] UserIntToChar(int userInt)
        {
            char[] _Chars = (userInt.ToString().ToCharArray());
            return _Chars;
        }

        public static void AddNewChar(char[] resultChars, List<char> userChars)
        {
            foreach (var _Char in resultChars)
            {
               userChars.Add(_Char);
            }
        }
    }
}
