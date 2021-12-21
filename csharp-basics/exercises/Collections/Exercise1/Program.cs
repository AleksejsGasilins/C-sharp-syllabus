using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> carList = new List<string>();
            carList.Add("Audi");
            carList.Add("BMW");
            carList.Add("Honda");
            carList.Add("Mercedes");
            carList.Add("VolksWagen");
            carList.Add("Mercedes");
            carList.Add("Tesla");

            foreach (var car in carList)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            HashSet<string> carHashSet = new HashSet<string>();

            for (int i = 0; i < carList.Count; i++)
            {
                carHashSet.Add(carList[i]);
            }

            foreach (var car in carHashSet)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            Dictionary<string, string> carDictionary = new Dictionary<string, string>();
            carDictionary.Add("Audi", "Germany");
            carDictionary.Add("BMW", "Germany");
            carDictionary.Add("Honda", "Japan");
            carDictionary.Add("Mercedes", "Germany");
            carDictionary.Add("VolksWagen", "Germany");
            carDictionary.Add("Tesla", "USA");

            Dictionary<string, string>.KeyCollection keys = carDictionary.Keys;
            foreach (var car in keys)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            Dictionary<string, string>.ValueCollection value = carDictionary.Values;
            foreach (var key in value)
            {
                Console.WriteLine(key);
            }

            Console.ReadKey();
        }
    }
}
