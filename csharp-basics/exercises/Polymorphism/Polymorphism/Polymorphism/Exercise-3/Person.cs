using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Person
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

        public virtual string GetFirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public virtual string GetLastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public virtual string GetAddress
        {
            get { return _address; }
            set { _address = value; }
        }

        public virtual int GetId
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {GetFirstName}, LastName: {GetLastName}, address: {GetAddress}, id: {GetId}");
        }
    }
}
