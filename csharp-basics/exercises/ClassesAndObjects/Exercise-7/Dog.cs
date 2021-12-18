using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Dog
    {
        private string _name { get; set; }
        private string _sex { get; set; }
        private string _father { get; set; }
        private string _mother { get; set; }

        public Dog(string name, string sex, string mother = "Unknown", string father = "Unknown")
        {
            _name = name;
            _sex = sex;
            _mother = mother;
            _father = father;
        }

        public string GetName()
        {
            return _name;
        }


        public string fathersName()
        {
            return _father;
        }

        public bool hasSameMotherAs(Dog otherDog)
        {
            if (_mother == otherDog._mother)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
