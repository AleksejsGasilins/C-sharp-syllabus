using System;
using System.Collections.Generic;

namespace PrintDayInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber;

            Console.WriteLine("Write the number: ");
            ConsoleKeyInfo userEnter = Console.ReadKey();

            if (char.IsDigit(userEnter.KeyChar))
            {
                dayNumber = int.Parse(userEnter.KeyChar.ToString());
            }
            else
            {
                dayNumber = -1;
            }

            switch (dayNumber)
                {
                    case 0:
                        Console.WriteLine("\n" + "Today is Monday!");
                        break;
                    case 1:
                        Console.WriteLine("\n" + "Today is Tuesday !");
                        break;
                    case 2:
                        Console.WriteLine("\n" + "Today is Wednesday!");
                        break;
                    case 3:
                        Console.WriteLine("\n" + "Today is Thursday!");
                        break;
                    case 4:
                        Console.WriteLine("\n" + "Today is Friday!");
                        break;
                    case 5:
                        Console.WriteLine("\n" + "Today is Saturday!");
                        break;
                    case 6:
                        Console.WriteLine("\n" + "Today is Sunday!");
                        break;
                    default:
                        Console.WriteLine("\n" + "Not a valid day!");
                        break;
            }
        }
    }
}
