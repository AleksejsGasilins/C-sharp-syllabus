using System;

namespace Exercise_8
{
    class AsciiFigure
    {
        static void Main(string[] args)
        {
            DrawFunction(3);
        }

        static void DrawFunction(int size)
        {
            for (int i = 0; i < size; i++)
            {
                string star = string.Empty; // use string
                for (int counter = 0; counter < 10; counter++)
                {
                    star += "*"; // append a star
                    Console.WriteLine(star);
                }
            }
        }
    }
}
