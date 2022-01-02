using System;

namespace Exercise_3
{
    public class Person : IDisplay
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id;

        public Person(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }

        public string GetName()
        {
            return _firstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public string GetAddress()
        {
            return _address;
        }

        public int GetId()
        {
            return _id;
        }

        public void Display()
        {
            Console.WriteLine(_firstName);
            Console.WriteLine(_lastName);
            Console.WriteLine(_address);
            Console.WriteLine(_id);
        }

    }
}
