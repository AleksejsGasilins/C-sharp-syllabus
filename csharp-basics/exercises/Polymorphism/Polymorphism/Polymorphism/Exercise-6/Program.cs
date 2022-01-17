using System;
using System.Collections.Generic;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal1 = new Mouse("Mouse", "Lora", 1.3, "farm");

            Console.WriteLine(animal1.GetAllInfo());
            Console.WriteLine(animal1.MakeSound());

            Console.WriteLine("Choose the amount of food for the animal:");
            var userFoodAmount = Convert.ToInt32(Console.ReadLine());

            var userFood = new Felime(userFoodAmount);
            var userFoodChoose = userFood.GetUserChoiceFood();

            if(animal1.MouseEat(userFoodChoose) == true)
            {
                Console.WriteLine(animal1.GetAllInfo());
            }
            else
            {
                Console.WriteLine($"\n2");
            }
        }
    }
}
