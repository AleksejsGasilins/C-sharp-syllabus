using System;

namespace Exercise_6
{
    class Cat : Mammal
    {
        public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string catBreed, int foodEaten = 0)
            : base(animalType, animalName, animalWeight, livingRegion, foodEaten, catBreed)
        {
        }

        public override string MakeSound()
        {
            return "> Meow - meow";
        }

        public override bool AnimalEat(string userInput)
        {
            if (userInput == "Vegetable")
            {
                return true;
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
