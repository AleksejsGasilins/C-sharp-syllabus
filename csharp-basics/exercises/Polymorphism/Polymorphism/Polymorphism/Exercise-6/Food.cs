using System;

namespace Exercise_6
{
    class Food
    {
        private int _quantity;

        public Food(int quantity)
        {
            _quantity = quantity;
        }

        public virtual string GetFoodAndQuan()
        {
           return $"{_quantity}";
        }
    }
}