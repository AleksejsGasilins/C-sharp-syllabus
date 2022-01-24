using System;

namespace Exercise_6
{
    class Vegetable : Food
    {
        private string _vegetable;

        public Vegetable(int quantity) : base(quantity)
        {
            _vegetable = "Vegetable";
        }

        public string GetVegetable()
        {
            return _vegetable;
        }
    }
}
