using System;

namespace Exercise_6
{
    class Tiger : Mammal
    {
        public Tiger(string animalType, string animalName, double animalWeight, string livingRegion, int foodEaten = 0)
            : base(animalType, animalName, animalWeight, livingRegion, foodEaten)
        {
        }

        public override string MakeSound()
        {
            return "> Rrrrrr-rrrrr";
        }

        public override bool AnimalEat(string userInput)
        {
            if (userInput == "Vegetable")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string GetAllInfo(int food = 0)
        {
            return base.GetAllInfo(food);
        }
    }
}
