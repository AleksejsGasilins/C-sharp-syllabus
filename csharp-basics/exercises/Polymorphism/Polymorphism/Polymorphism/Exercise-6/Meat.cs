using System;

namespace Exercise_6
{
    class Meat : Food
    {
        private string _meat;

        public Meat(int quantity) : base(quantity)
        {
            _meat = "Meat";
        }

        public string GetMeat()
        {
            return _meat;
        }
    }
}
