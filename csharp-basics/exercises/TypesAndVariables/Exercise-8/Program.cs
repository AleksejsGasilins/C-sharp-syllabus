using System;

namespace Exercise_8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please select the convertor direction: ");
            Console.WriteLine("1. From Minutes to Hours.");
            Console.WriteLine("2. From Minutes to Days.");
            Console.WriteLine("3. From Minutes to Years.");

            string selection = Console.ReadLine();
            decimal x = 0;
            decimal y = 0;
            decimal j = 0;

            switch (selection)
            {
                case "1":
                    Console.WriteLine("Write the number in minutes: ");
                    x = MinutesInHours(Console.ReadLine());
                    Console.WriteLine("Hours to Minutes: {0:F2}", x);
                    break;
                case "2":
                    Console.WriteLine("Write the number in minutes: ");
                    y = HoursInDays(Console.ReadLine());
                    Console.WriteLine("Days to Minutes: {0:F2}", y);
                    break;
                case "3":
                    Console.WriteLine("Write the number in minutes: ");
                    j = DaysInYears(Console.ReadLine());
                    Console.WriteLine("Years to Minutes: {0:F2}", j + "");
                    break;
                default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static decimal MinutesInHours(string hoursYearAndDays)
        {
            decimal x = Decimal.Parse(hoursYearAndDays);

            decimal minutesInHours = x * 0.01666668m;

            return minutesInHours;
        }

        public static decimal HoursInDays(string hoursYearAndDays)
        {
            decimal y = Decimal.Parse(hoursYearAndDays);

            decimal hoursInDays = y * 0.000694445m;

            return hoursInDays;
        }

        public static decimal DaysInYears(string hoursYearAndDays)
        {
            decimal j = Decimal.Parse(hoursYearAndDays);

            decimal daysInYears = j * 1.9025890411e-6m;

            return daysInYears;
        }
    }
}
