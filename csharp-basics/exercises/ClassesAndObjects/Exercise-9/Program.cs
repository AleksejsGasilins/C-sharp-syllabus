using System;
using System.Drawing;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(5, 2);
            var p2 = new Point(-3, 6);

            Console.WriteLine(p1.getPoint());
            Console.WriteLine(p2.getPoint());

            p1.SwapPoints(p2);

            Console.WriteLine(p1.getPoint());
            Console.WriteLine(p2.getPoint());
        }
    }
}
