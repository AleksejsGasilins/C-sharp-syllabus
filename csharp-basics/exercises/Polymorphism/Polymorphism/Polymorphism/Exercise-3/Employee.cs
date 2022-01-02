using System;

namespace Exercise_3
{
    class Employee : IDisplay
    {
        protected string _jobTitle { get; set; }

        public Employee(string jobTitle)
        {
            _jobTitle = jobTitle;
        }

        public void Display()
        {
            Console.WriteLine(_jobTitle);
        }
    }
}
