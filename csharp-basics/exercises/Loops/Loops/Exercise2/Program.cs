using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int powNum = 0;
            
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                powNum = i * i;
            }

            Console.WriteLine("Your answer: " + powNum);
            Console.ReadKey();
        }
    }
}
