using System;

namespace Exercise_6
{
    abstract class Animal
    {
        private string _animalName;
        private string _animalType;
        private double _animalWeight;
        private int _foodEaten;

        public Animal(string animalType, string animalName, double animalWeight, int foodEaten)
        {
            _animalType = animalType;
            _animalName = animalName;
            _animalWeight = animalWeight;
            _foodEaten = foodEaten;
        }

        public virtual string GetAnumalType
        {
            get  { return _animalType; }
            set { _animalType = value; }
        }

        public virtual string GetAnimalName
        {
            get { return _animalName; }
            set { _animalName = value; }
        }

        public virtual double GetAnumalWeight
        {
            get { return Math.Round(_animalWeight, 1); }
            set { _animalWeight = value; }
        }

        public virtual int GetFoodEaten
        {
            get { return _foodEaten; }
            set { _foodEaten = value; }
        }

        public virtual string MakeSound()
        {
           return "> Am-nam-nam-nam";
        }

        public virtual void Eat(Food food)
        {
            _foodEaten += Convert.ToInt32(food);
            Console.WriteLine(_foodEaten);
        }

        public virtual string GetAllInfo(int food)
        {
           return $"{_animalType} {_animalName} {_animalWeight}";
        }
    }
}
