using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            string Eyes;
            string Teeth; 
            string Hair;
            int Age;
            int Height; 
            int Weight;
            decimal HeightInCm;
            decimal WeightInKg;

            Name = "Zed A. Shaw";
            Age = 35;
            Height = 74;  // inches
            Weight = 180; // lbs
            Eyes = "Blue";
            Teeth = "White";
            Hair = "Brown";

            HeightInCm = Math.Round((Height * 2.54m), 2);
            WeightInKg = Math.Round((Weight * 0.453592m), 2);

            Console.WriteLine("Let's talk about " + Name + ".");
            Console.WriteLine("He's " + HeightInCm + " inches tall.");
            Console.WriteLine("He's " + WeightInKg + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + Eyes + " eyes and " + Hair + " hair.");
            Console.WriteLine("His teeth are usually " + Teeth + " depending on the coffee.");
            Console.WriteLine("If I add " + Age + ", " + HeightInCm + ", and " + WeightInKg
                              + " I get " + (Age + HeightInCm + WeightInKg) + ".");
            Console.ReadKey();
        }
    }
}