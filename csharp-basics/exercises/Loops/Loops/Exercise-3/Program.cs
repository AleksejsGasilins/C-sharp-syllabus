using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[20];
            Random rndNum = new Random();

            for (int i = 0; i < 20; i++)
            {
                nums[i] = rndNum.Next(1, 100);
                Console.WriteLine(i + "-" + nums[i] + " ");

                if (i == 20 - 1)
                {
                    Console.WriteLine("Enter the position number you want to receive: ");
                    var userNumPosition = Console.ReadLine();
                    int userNumInInt = Convert.ToInt32(userNumPosition);

                    Console.WriteLine("Here is your number: ");
                    Console.WriteLine(nums[userNumInInt]);
                    Console.ReadKey();
                }
            }
        }
    }
}
