using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Student : Person
    {
        private double _gpa;

        public Student(string name, string lastName, string address, int id, double gpa)
            : base(name, lastName, address, id)
        {
            _gpa = gpa;
        }

        public double GetGpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($" his GPA: {GetGpa}");
        }
    }
}
