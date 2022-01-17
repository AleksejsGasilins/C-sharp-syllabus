using System;

namespace Exercise_6
{
    class Felime : Food
    {
        public Felime(int quantity) : base(quantity)
        {

        }

        public string GetUserChoiceFood()
        {
            Console.WriteLine("Choose food for the animal: ");
            Console.WriteLine("1: Vegetable");
            Console.WriteLine("2: Meat");
            var userInput = Console.ReadKey();

            int userInt;

            if (char.IsDigit(userInput.KeyChar))
            {
                userInt = int.Parse(userInput.KeyChar.ToString());
            }
            else
            {
                userInt = -1;
            }

            string food = null;

            switch(userInt)
            {
                case 1:
                    food = "Vegetable";
                    break;
                case 2:
                    food = "Meat";
                    break;
            }

            return food;
        }
    }
}
