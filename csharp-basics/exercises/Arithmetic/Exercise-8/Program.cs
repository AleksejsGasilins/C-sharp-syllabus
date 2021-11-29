using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees(7.50m, 35);
            Employees(8.20m, 47);
            Employees(10.00m, 73);
            
        }

        static void Employees(decimal BPay, int hours)
        {
            if (BPay < 8m || hours > 60)
            {
                Console.WriteLine("Error");
            }
            else if (hours > 40)
            {
                var all = (40 * BPay + (hours - 40) * (BPay * 1.5m));
                Console.WriteLine("$" + Math.Round(all, 2));
            }
            else 
            {
                Console.WriteLine(hours * BPay);
            }
        }
    } 
}
