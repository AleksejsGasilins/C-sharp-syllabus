using System;
using System.Collections.Generic;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Mammal> animals = new List<Mammal>();
            animals.Add(new Mouse("Mouse", "Lora", 1.37, "farm"));
            animals.Add(new Zebra("Zebra", "Fomror", 53.15, "Afrika"));
            animals.Add(new Cat("Cat", "Gray", 1.10, "Home", "Persian"));
            animals.Add(new Tiger("Tiger", "Konan", 97.62, "Afrika"));

            List<string> allAnimals = new List<string>();

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetAllInfo());
                Console.WriteLine(animal.MakeSound());

                Console.WriteLine("Choose the amount of food for the animal:");
                var userFoodAmount = Convert.ToInt32(Console.ReadLine());

                var userFood = new Felime(userFoodAmount);
                var userFoodChoose = userFood.GetUserChoiceFood();

                var animalInfo = animal.GetAllInfo(userFoodAmount);
                var animalNotEat = animal.GetAnumalType;

                if (animal.AnimalEat(userFoodChoose) == true)
                {
                    allAnimals.Add(animalInfo);
                    Console.WriteLine($"\n> {animalInfo}");
                }
                else
                {
                    allAnimals.Add(animalInfo);
                    Console.WriteLine($"\n> {animalNotEat} are not eating that type of food");
                    Console.WriteLine("End");
                }
            }

            Console.WriteLine(string.Join(",", allAnimals) + ".");
        }
    }
}
