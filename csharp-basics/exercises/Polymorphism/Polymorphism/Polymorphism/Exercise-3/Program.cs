using System;
using System.Collections.Generic;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = new List<IDisplay>();
            info.Add(new Person("Aleks", "Gasilins", "Kurzemes", 1));
            info.Add(new Employee("Teacher"));
            info.Add(new Student(6.5));

            foreach (var itam in info)
            {
                Console.WriteLine(itam);
            }
            /*
             * - Create an instant of class Student and an instant of class Employee with proper values for the attributes.
             * - Display the content of each class using Display() method.
             */
        }
    }
}