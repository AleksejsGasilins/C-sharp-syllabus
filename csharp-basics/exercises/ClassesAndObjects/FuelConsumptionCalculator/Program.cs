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
            double endKilometers = 0;
            double liters = 0;
            
            Console.WriteLine();

            Car car1 = new Car(startKilometers, endKilometers, liters);
            Car car2 = new Car(startKilometers, endKilometers, liters);

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter first reading: ");
                startKilometers = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter end reading: ");
                endKilometers = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                liters = Convert.ToDouble(Console.ReadLine());
                car1.FillUp(startKilometers, liters);

                //Console.Write("Enter first reading: ");
                //startKilometers = Convert.ToDouble(Console.ReadLine());
                //Console.Write("Enter end reading: ");
                //endKilometers = Convert.ToDouble(Console.ReadLine());
                //Console.Write("Enter liters reading: ");
                //liters = Convert.ToDouble(Console.ReadLine());
                //car2.FillUp(startKilometers, liters);
            }

            car1 = new Car(startKilometers, endKilometers, liters);
            car2 = new Car(startKilometers, endKilometers, liters);

            Console.WriteLine("Kilometers per liter are " + car1.CalculateConsumption() + " gasHog:" + car1.GasHog());
            Console.WriteLine("Car1 Kilometers per liter are " + car2.CalculateConsumption()+ " economyCar:" + car2.EconomyCar());
            Console.ReadKey();
        }
    }
}
