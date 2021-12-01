using System;

namespace SadFor
{
    class Program
    {
        private static void Main(string[] args)
        {
            Test1(10, 2.5);
            Test1(20, 4);
            Test1(15, 3);
        }

        public static void Test1(double numberOne, double numberTwo)
        {
            double x = Convert.ToDouble(numberOne);
            double y = Convert.ToDouble(numberTwo);

            for (int i = 0; i < x; i++)
            {
                if (Math.Sqrt(i) > y)
                {
                    Console.WriteLine(i);
                    Console.ReadKey();
                }
            }
        }
    }
}