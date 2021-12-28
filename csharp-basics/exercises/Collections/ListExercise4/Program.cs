using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };
            colors.Insert(0, "Yellow");
            colors.Insert(2, "Pink");


            for (int i = 0; i < colors.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("First element: " + colors[i]);
                }
                else if (i == 2)
                {
                    Console.WriteLine("Third element: " + colors[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
