using System;

namespace Exercise_8
{
    class AsciiFigure
    {
        static void Main(string[] args)
        {
            DrawFunction(5);
            DrawFunction(3);
            DrawFunction(7);
        }

        static void DrawFunction(int height)
        {
            string star = "****";

            for (int i = 0; i < height - 1; i++)
            {
                for (int k = height - 4; k > i - 3; k--)
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
                for (int v = height - 4; v > i - 3; v--)
                {
                    Console.Write("\\\\\\\\");
                }
                Console.WriteLine();
            }

            string emptyString = "";

            for (int m = 1; m < height; m++)
            {
                emptyString +=  star + star;
            }

            Console.Write(emptyString);
            Console.WriteLine();
        }
    }
}
