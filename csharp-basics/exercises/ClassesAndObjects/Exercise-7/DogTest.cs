using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class DogTest
    {
        public DogTest()
        {
            var dog1 = new Dog("Max", "male", "Lady", "Rocky");
            var dog2 = new Dog("Rocky", "male", "Molly", "Sam");
            var dog3 = new Dog("Sparky", "male");
            var dog4 = new Dog("Buster", "male", "Lady", "Sparky");
            var dog5 = new Dog("Sam", "male");
            var dog6 = new Dog("Lady", "female");
            var dog7 = new Dog("Molly", "female");
            var dog8 = new Dog("Coco", "female", "Molly", "Buster");

            var dogs = new List<Dog>
            {
                dog1, dog2, dog3,
                dog4, dog5, dog6,
                dog7, dog8
            };
        }

        public static Dog[] getDogByName(Dog[] dogs)
        {
            foreach (var dog in dogs)
            {
                if (dog.GetName() == )
                {
                    
                }
            }
        }

    }
}
