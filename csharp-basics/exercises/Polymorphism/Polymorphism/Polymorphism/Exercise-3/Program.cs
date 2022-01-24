using System;
using System.Collections.Generic;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Vlad", "Nap", "ferona-22", 1);
            p1.Display();

            Person p2 = new Employee("Olan", "Virs", "Unosa-34", 2, "Teacher");
            p2.Display();

            Person p3 = new Student("Clap", "Popor", "Nursa-2", 3, 7.12);
            p3.Display();

            Console.ReadKey();
        }
    }
}