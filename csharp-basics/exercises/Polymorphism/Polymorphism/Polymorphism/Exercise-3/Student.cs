using System;

namespace Exercise_3
{
    public class Student : Person
    {
        protected double _gpa { get; set; }

        public Student(double gpa) : base()
        {
            _gpa = gpa;
        }

        public void Display()
        {
            Console.WriteLine(_gpa);
        }
    }
}
