using System;
using System.ComponentModel.Design;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string allNumbers = " ";
            decimal meters = 0;
            decimal hours = 0;
            decimal minutes = 0;
            decimal seconds = 0;
            decimal timeInSeconds = 0;

            for (int i = 0; i < 4; i++) 
            { 
                if (i == 0)
                {
                    Console.WriteLine("Enter distance in meters: ");
                    allNumbers = Console.ReadLine();
                    meters = Convert.ToDecimal(allNumbers);
                }
                else if (i == 1)
                {
                    Console.WriteLine("Enter hours: ");
                    allNumbers = Console.ReadLine();
                    hours = Convert.ToDecimal(allNumbers);
                } 
                else if (i == 2)
                {
                    Console.WriteLine("Enter minutes: ");
                    allNumbers = Console.ReadLine();
                    minutes = Convert.ToDecimal(allNumbers);
                }
                else if (i == 3)
                {
                    Console.WriteLine("Enter seconds: ");
                    allNumbers = Console.ReadLine();
                    seconds = Convert.ToDecimal(allNumbers);
                }

                if (decimal.TryParse(allNumbers, out var parsedNumber))
                {
                }
                else
                {
                    Console.WriteLine("Error");
                    Console.ReadKey();
                    return;
                }
            }

            timeInSeconds = hours * 3600 + minutes * 60 + seconds;

            Console.WriteLine("Test Data");
            Console.WriteLine("Input distance in meters: " + meters);
            Console.WriteLine("Input hour: " + hours);
            Console.WriteLine("Input minutes: " + minutes);
            Console.WriteLine("Input seconds: " + seconds);
            Console.WriteLine("Expected Output: ");
            Console.WriteLine("Your speed in meters/second is: " + decimal.Round((meters / timeInSeconds), 8));
            Console.WriteLine("Your speed in km/h is: " + decimal.Round((meters / 1000) / (timeInSeconds / 3600), 8));
            Console.WriteLine("Your speed in miles/h is: " + decimal.Round((meters / 1609) / (timeInSeconds / 3600), 8));
        }
    }
}