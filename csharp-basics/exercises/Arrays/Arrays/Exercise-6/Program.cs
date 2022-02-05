using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array1Clon = new int[10];

            for (int i = 0; i < array1.Length; i++)
            {
                Random rnd = new Random();
                int value = rnd.Next(1, 100);

                array1[i] = value;
                array1Clon[i] = value;
                array1Clon[9] = -7;

                Console.Write(array1Clon[i] + " ");
            }

            Console.WriteLine();

            for (int j = 0; j < array1.Length; j++)
            {
                array2[j] = array1[j];

                Console.Write(array2[j] + " ");
            }
        }
    }
}
