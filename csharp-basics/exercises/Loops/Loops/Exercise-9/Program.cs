using System;

namespace Exercise_9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {
            Console.Write("Desired sum: ");
            var userNum = Console.ReadKey();
            
            Console.WriteLine();

            int Bowl;

            if (char.IsDigit(userNum.KeyChar))
            {
                Bowl = int.Parse(userNum.KeyChar.ToString());
            }
            else
            {
                Bowl = -1;
            }

            Random rnd = new Random();
            int firstRnd = rnd.Next(1, 6);
            int secondRnd = rnd.Next(1, 6);

            int rndSum = firstRnd + secondRnd;

            for (int i = rndSum; i <= Bowl + 1; i++)
            {
                firstRnd = rnd.Next(1, 6);
                secondRnd = rnd.Next(1, 6);
                rndSum = firstRnd + secondRnd;

                Console.WriteLine($"{firstRnd} and {secondRnd} = {rndSum}");
            }
        }
    }
}
