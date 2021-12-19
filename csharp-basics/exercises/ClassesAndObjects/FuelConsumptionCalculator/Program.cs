using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            double startKilometers = 0;
            double liters = 0;
            double mileage = 0;

            Console.WriteLine();

            Car car1 = new Car(startKilometers);
            Car car2 = new Car(startKilometers);

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter mileage car1 reading: ");
                mileage = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter liters car1 reading: ");
                liters = Convert.ToDouble(Console.ReadLine());
                car1.FillUp(mileage, liters);
                Console.WriteLine(car1.CalculateConsumption());

                Console.Write("Enter mileage car2 reading: ");
                mileage = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter liters car2 reading: ");
                liters = Convert.ToDouble(Console.ReadLine());
                car2.FillUp(mileage, liters);
                Console.WriteLine(car2.CalculateConsumption());
            }
            Console.ReadKey();
        }
    }
}
