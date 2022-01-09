using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Employee : Person
    {
        private string _jobTitle;

        public Employee(string name, string lastName, string address, int id, string jobTitle)
            : base(name, lastName, address, id)
        {
            _jobTitle = jobTitle;
        }

        public string GetJobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($" is a: {GetJobTitle}");
        }
    }
}
