using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var sounds = new List<ISound>();
            sounds.Add(new Firework());
            sounds.Add(new Radio());
            sounds.Add(new Parrot());

            Console.WriteLine("Choice sound: ");
            Console.WriteLine("1. Firework");
            Console.WriteLine("2. Radio");
            Console.WriteLine("3. Parrot");
            Console.Write("Your number is: ");
            var userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine(sounds[0].PlaySound());
                    break;
                case 2:
                    Console.WriteLine(sounds[1].PlaySound());
                    break;
                case 3:
                    Console.WriteLine(sounds[2].PlaySound());
                    break;
            }
        }
    }
}