using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for (int i = 1; i <= 10; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
