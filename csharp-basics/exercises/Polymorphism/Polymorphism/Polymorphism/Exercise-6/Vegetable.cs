using System;

namespace Exercise_6
{
    class Vegetable : Food
    {
        private string _vegetable;

        public Vegetable(int quantity, string vegetable) : base(quantity)
        {
            _vegetable = vegetable = "Vegetable";
        }

        public string GetVegetable()
        {
            return _vegetable;
        }

        public void PrintVegetable(Food quantity)
        {
            Console.WriteLine($"{_vegetable} {quantity}");
        }
    }
}
