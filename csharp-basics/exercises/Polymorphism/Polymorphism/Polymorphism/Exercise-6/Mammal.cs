using System;

namespace Exercise_6
{
    abstract class Mammal : Animal
    {
        private string _livingRegion;

        private string _catBreed;

        public Mammal(string animalType, string animalName, double animalWeight, string livingRegion, int foodEaten, string catBreed = null)
            : base(animalType, animalName, animalWeight, foodEaten)
        {
            _livingRegion = livingRegion;
            _catBreed = catBreed;
        }

        public string GetCatBread
        {
            get { return _catBreed; }
            set { _catBreed = value; }
        }

        public virtual bool AnimalEat(string userInput)
        {
            bool animalEat = false;

            if (userInput == "Vegetable")
            {
                return true;
            }
            else if (userInput == "Meat")
            {
                return true;
            }

            return animalEat;
        }

        public override string GetAllInfo(int food = 0)
        {
            if(_catBreed == null)
            {
                return $"{GetAnumalType}[{GetAnimalName}, {GetAnumalWeight}, {_livingRegion}, {food}]";
            }
            else
            {
                return $"{GetAnumalType}[{GetAnimalName}, {_catBreed}, {GetAnumalWeight}, {_livingRegion}, {GetFoodEaten}]";
            }
        }
    }
}
