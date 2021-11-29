using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            string data;

            Console.WriteLine("Hi, what numbers do you want to add? "); 
            data = Console.ReadLine();

            if (int.TryParse(data, out var parsedNumber))
            {
                x = Convert.ToInt32(data);

                Console.WriteLine("Second number");
            }
            else
            {
                Console.WriteLine("Not suitable symbol");
                Console.ReadKey();
            }

            data = Console.ReadLine();

            if (int.TryParse(data, out var parsedNumber2))
            {
                y = Convert.ToInt32(data);

                Console.WriteLine("Answer ");
                Console.WriteLine(x + y);
            }
            else
            {
                Console.WriteLine("Not suitable symbol");
                Console.ReadKey();
            }



        }
    }
}
