using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        public SortedDictionary<string, string> _data;

        public PhoneDirectory(string name, string number)
        {
            _data = new SortedDictionary<string, string>();
            _data.Add(name, number);
        }

        public string Find(string name)
        {
            string value = "";

            if (_data.TryGetValue(name, out value))
            {
                return value;
            }

            return null;
        }

        public string GetNumber(string name) 
        {
            var number = Find(name);
            if (number == null) 
            {
                return null;
            } 
            else 
            {
                return number;
            }
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }

            var phoneNum = Find(name);
            if (phoneNum != null) 
            {
                _data[name] = number;
            }
            else 
            {
                _data.Add(name, number);
            }
        }
    }
}