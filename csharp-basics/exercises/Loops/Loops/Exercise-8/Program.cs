using System;

namespace Exercise_8
{
    class AsciiFigure
    {
        static void Main(string[] args)
        {
            DrawFunction(3);
        }

        static void DrawFunction(int height)
        {
            string star = "****";

            for (int i = 0; i < height - 1; i++)
            {
                for (int k = height; k > i; k--)
                {
                    Console.Write("////");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(star);
                }
                for (int s = 1; s <= i; s++)
                {
                    Console.Write(star);
                }
                for (int v = height; v > i - 2; v--)
                {
                    Console.Write("\\\\");
                }
                if (i == height - 1)
                {
                    for (int m = 1; m < height; m++)
                    {
                        Console.Write(star);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
