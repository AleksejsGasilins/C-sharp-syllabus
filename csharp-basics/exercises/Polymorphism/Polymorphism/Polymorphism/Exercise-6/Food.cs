using System;

namespace Exercise_6
{
    class Food
    {
        private int _quantity;

        private string _foodEaten;

        public Food(int quantity)
        {
            _quantity = quantity;
        }

        public string foodSelection(int userNum)
        {
            string eat = null;

            switch (userNum)
            {
                case 1:
                    eat = "Vegetable";
                    break;
                case 2:
                    eat = "Meat";
                    break;
            }

            return eat;
        }
    }
}