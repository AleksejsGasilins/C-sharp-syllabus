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
            }

            foreach (int index in nums)
            {
                Console.Write(nums[7]);
            }

        }
    }
}
