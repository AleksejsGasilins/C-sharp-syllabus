using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            double startKilometers;
            double endKilometers;
            double liters;
            
            Console.WriteLine();

            Car car = new Car(0, 0, 0);
            Car car1 = new Car(0, 0, 0);

            for (int i = 0; i < 1; i++)
            {
                Console.Write("Enter first reading: ");
                startKilometers = Convert.ToDouble(Console.ReadLine());    
                Console.Write("Enter liters reading: ");
                liters = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter end reading: ");
                endKilometers = Convert.ToDouble(Console.ReadLine());
                car.FillUp(startKilometers, liters);
                
                Console.Write("Enter first reading: ");
                startKilometers = Convert.ToDouble(Console.ReadLine());    
                Console.Write("Enter liters reading: ");
                liters = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter end reading: ");
                endKilometers = Convert.ToDouble(Console.ReadLine());
                car1.FillUp(startKilometers, liters);
            }

            Console.WriteLine("Kilometers per liter are " + car.CalculateConsumption() + " gasHog:" + car.GasHog());
            Console.WriteLine("Car1 Kilometers per liter are " + car1.CalculateConsumption()+ " economyCar:" + car.EconomyCar());
            Console.ReadKey();
        }
    }
}
