using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Class1
    {
        public string _path;
        public Class1(string path)
        {
            _path = path;
        }

        public static HashSet<string> GetCity(string path)
        {
            HashSet<string> cityName = new HashSet<string>();

            string text = File.ReadAllText(path);
            string[] lines = text.Split(Environment.NewLine.ToCharArray());

            foreach (var line in lines)
            {
                var city = line.Split('-')[0];
                cityName.Add(city);
            }

            return cityName;
        }

        public static List<string> GetFlight(string userChoice, string path)
        {
            userChoice = userChoice.Trim();

            List<string> flight = new List<string>();

            string text = File.ReadAllText(path);
            string[] lines = text.Split(Environment.NewLine.ToCharArray());

            foreach (var line in lines)
            {
                var city = line.Split(new[] { "->" }, StringSplitOptions.None).Select(p => p.Trim()).ToList();

                if (userChoice == city[0])
                {
                    flight.Add(city[1]);
                }
            }

            return flight;
        }
    }
}
