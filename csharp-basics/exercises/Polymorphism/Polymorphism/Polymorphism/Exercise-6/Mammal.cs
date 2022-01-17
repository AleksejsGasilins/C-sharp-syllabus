using System;

namespace Exercise_6
{
    abstract class Mammal : Animal
    {
        private string _livingRegion;

        public Mammal(string animalType, string animalName, double animalWeight,string livingRegion, int foodEaten) : base(animalType, animalName, animalWeight, foodEaten)
        {
            _livingRegion = livingRegion;
        }

        public override string GetAllInfo()
        {
           return $"{base.GetAllInfo()} {_livingRegion}";
        }
    }
}
