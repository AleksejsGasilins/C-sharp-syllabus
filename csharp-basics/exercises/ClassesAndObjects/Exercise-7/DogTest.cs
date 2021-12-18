using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class DogTest
    {
        public Dog[] dogs { get; protected set; }

        public DogTest()
        {
            dogs = new Dog[]
            {
                new Dog("Max", "male", "Lady", "Rocky"),
                new Dog("Rocky", "male", "Molly", "Sam"),
                new Dog("Sparky", "male"),
                new Dog("Buster", "male", "Lady", "Sparky"),
                new Dog("Sam", "male"),
                new Dog("Lady", "female"),
                new Dog("Molly", "female"),
                new Dog("Coco", "female", "Molly", "Buster")
            };
        }

        public Dog GetDogByName(string name)
        {
            foreach (var dog in dogs)
            {
                var dogName = dog.GetName();

                if (dogName == name)
                {
                    return dog;
                }
            }

            return null;
        }

        public string getFathersNameByDogName(string name)
        {
            var father = GetDogByName(name);
            if (father != null)
            {
                return father.fathersName();
            }
            else
            {
                return "No dog with that name";
            }
        }

        public void tests()
        {
            Console.WriteLine(getFathersNameByDogName("Coco"));
            Console.WriteLine(getFathersNameByDogName("Sparky"));

            if (GetDogByName("Coco").hasSameMotherAs(GetDogByName("Rocky")))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        public void tests2()
        {
            Console.WriteLine(getFathersNameByDogName("Max"));
            Console.WriteLine(getFathersNameByDogName("Rocky"));

            if (GetDogByName("Sparky").hasSameMotherAs(GetDogByName("Buster")))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
