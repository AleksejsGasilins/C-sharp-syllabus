using System;

namespace Exercise_6
{
    class Meat : Food
    {
        private string _meat;

        public Meat(int quantity, string meat) : base(quantity)
        {
            _meat = "Meat";
        }

        public string GetMeat()
        {
            return _meat;
        }

        public void PrintMeat(Food quantity)
        {
            Console.WriteLine($"{_meat} {quantity}");
        }
    }
}
