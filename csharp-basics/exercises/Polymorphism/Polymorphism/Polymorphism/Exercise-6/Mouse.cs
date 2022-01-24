using System;

namespace Exercise_6
{
    class Mouse : Mammal
    {
        public Mouse(string animalType, string animalName, double animalWeight, string livingRegion, int foodEaten = 0)
            : base(animalType, animalName, animalWeight, livingRegion, foodEaten)
        {
        }

        public override string MakeSound()
        {
           return "> Squeak-squeak";
        }

        public override bool AnimalEat(string userInput)
        {
            if (userInput == "Vegetable")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string GetAllInfo(int food = 0)
        {
            return base.GetAllInfo(food);
        }
    }
}
