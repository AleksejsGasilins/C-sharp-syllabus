using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            int month;
            int year;

            Console.Write("Enter day: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());

            Data data = new Data(month, day, year);
            data.DisplayDate();

            Console.Write("Enter day: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());

            data.SetDay(day);
            data.SetMonth(month);
            data.SetYear(year);
            data.DisplayDate();
        }
    }
}
