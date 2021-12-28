using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = @"E:\Programming\Studying\C-sharp-syllabus\csharp-basics\exercises\Collections\FlightPlanner/flights.txt";

        private static void Main(string[] args)
        {
            var userInput = "";

            do
            {
                Console.WriteLine("What would you like to do: ");
                Console.WriteLine("To display list of the cities press 1");
                Console.WriteLine("To exit program press #");

                userInput = Console.ReadLine();

            } while (userInput != "1" && userInput != "#");

            if (userInput == "#")
            {
                Environment.Exit(0);
            }

            var cityName = Class1.GetCity(Path).ToList();

            for (int i = 0; i < cityName.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cityName[i]}");
            }

            var userInput2 = "";

            do
            {
                Console.WriteLine("\nTo select a city from which you would like to start");
                userInput2 = Console.ReadLine();

            } while (!Regex.IsMatch(userInput2, @"\d") || cityName.ElementAtOrDefault(Convert.ToInt32(userInput2) - 1) == null);

            List<string> route = new List<string>();

            var userChoice = cityName[Convert.ToInt32(userInput2) - 1];

            route.Add(userChoice);

            var startCity = userChoice.Trim();

            do
            {
                var getFlight = Class1.GetFlight(userChoice, Path);

                for (int i = 0; i < getFlight.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {getFlight[i]}");
                }

                do
                {
                    Console.WriteLine("\nTo select a city from which you would like to go");
                    userInput2 = Console.ReadLine();

                } while (!Regex.IsMatch(userInput2, @"\d") || getFlight.ElementAtOrDefault(Convert.ToInt32(userInput2) - 1) == null);

                userChoice = getFlight[Convert.ToInt32(userInput2) - 1];

                route.Add(userChoice);

            } while (startCity != userChoice);

            Console.WriteLine("Your route.");
            Console.WriteLine(string.Join(" -> ", route));

            Console.ReadKey();
        }
    }
}