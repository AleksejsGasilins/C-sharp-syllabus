using System;

namespace Exercise_6
{
    abstract class Animal
    {
        private string _animalName;
        private string _animalType;
        private double _animalWeight;
        private int _foodEaten;

        public Animal(string animalType, string animalName, double animalWeight, int foodEaten = 0)
        {
            _animalType = animalType;
            _animalName = animalName;
            _animalWeight = animalWeight;
            _foodEaten = foodEaten;
        }

        public string GetAnumalType()
        {
            return _animalType;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Am-nam-nam-nam");
        }

        public virtual void Eat(Food food)
        {
            _foodEaten += Convert.ToInt32(food);
            Console.WriteLine(_foodEaten);
        }

        public virtual string GetAllInfo()
        {
           return $"{_animalType} {_animalName} {_animalWeight}";
        }
    }
}
