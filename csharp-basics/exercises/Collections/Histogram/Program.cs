using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = @"E:\Programming\Studying\C-sharp-syllabus\csharp-basics\exercises\Collections\Histogram\midtermscores.txt";

        private static void Main(string[] args)
        {
            var numsList = СountingLikes.GetNumbers(Path);

            var min = 0;
            var max = 9;

            for (int i = 1; i <= 11; i++)
            {
                var stars = "";
                var count = 0;

                foreach (var num in numsList)
                {
                    if (num >= min && num <= max)
                    {
                        count += 1;
                    }
                }

                for (int j = 0; j < count; j++)
                {
                    stars += "*";
                }

                if (i == 1)
                {
                    Console.WriteLine($"0{min}-0{max}: {stars}");
                }
                else if (i == 11)
                {
                    Console.WriteLine($"  {max}: {stars}");
                }
                else
                {
                    Console.WriteLine($"{min}-{max}: {stars}");
                }

                if (i <= 9)
                {
                    min += 10;
                    max += 10;
                }
                else
                {
                    min += 10;
                    max += 1;
                }
            }

            Console.ReadKey();
        }
    }
}
