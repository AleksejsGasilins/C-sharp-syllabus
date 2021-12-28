using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string color1 = "Pink";
            string color2 = "Yellow";

            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");

            Console.WriteLine(string.Join(",", colors));

            colors.Insert(0, color1);
            colors.Insert(2, color2);

            Console.WriteLine(string.Join(",", colors));

            Console.ReadKey();
        }
    }
}
