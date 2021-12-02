using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classesName =
            {
                "English III", "Precalculus", "Music Theory",
                "Biotechnology", "Principles of Technology I",
                "Latin II", "AP US History", "Business Computer Infomation Systems"
            };

            string[] TeachersName =
            {
                "Ms. Lapan", "Mrs. Gideon", "Mr. Davis",
                "Ms. Palmer", "Ms. Garcia", "Mrs. Barnett",
                "Ms. Johannessen", "Mr. James"
            };

            var text = new System.Text.StringBuilder();
            string Columns = "";
            int[] Coluns =
            {
                1, 2, 3, 4,
                5, 6, 7, 8
            };

            for (int i = 0; i < classesName.Length; i++)
            { 
                Columns = "|" + Coluns[i] + "|"; 
                text.Append(Columns + (String.Format("{0,37} {1,30:N0}\n", classesName[i] + "|", TeachersName[i] + "|")));
            }

            int CountOfColumns = Coluns.Length;
            int OneLineLenght = (text.Length / CountOfColumns) - 3;

            linePlus(OneLineLenght);
            Console.WriteLine();
            Console.Write(text);
            linePlus(OneLineLenght);
        }

        private static void linePlus(int OneLineLenght)
        {
            for (int i = OneLineLenght; i != 0; i--)
            {
                if (i == OneLineLenght)
                {
                    Console.Write("+");
                }

                Console.Write("-");

                if (i == 1)
                {
                    Console.Write("+");
                }
            }
        }
    }
}