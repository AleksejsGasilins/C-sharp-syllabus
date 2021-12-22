using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../FlightPlanner/flights.txt";

        private static void Main(string[] args)
        {
            List<string> cities = new List<string>()
            {
                "San Jose",
                "San Francisco",
                "Anchorage",
                "New York",
                "Honolulu",
                "Denver"
            };

            ConsoleKeyInfo userChoice;

            do
            {
                Console.WriteLine("What would you like to do: ");
                Console.WriteLine("To display list of the cities press 1");
                Console.WriteLine("To exit program press #");

                userChoice = Console.ReadKey();


            } while (userChoice.ToString() == "1" || userChoice.ToString() == "#");

            if (userChoice.ToString() == "1")
            {
                Console.WriteLine("All Cities: ");
                foreach (var city in cities)
                {
                    Console.WriteLine(city);
                }
            }




            //var readText = File.ReadAllLines(Path);
            //foreach (var s in readText)
            //{
            //    Console.WriteLine(s);
            //}
            Console.ReadKey();
        }
    }
}
