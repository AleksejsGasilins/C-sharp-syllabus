using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        private static void Main(string[] args)
        {
            Car car = new Car(70, new FuelGauge(50), new Odometer(999980));

            while (car.GetFuelGauge().GetFuel() > 0)
            {
                car.GetOdometer().Drive(car.GetFuelGauge());
                Console.WriteLine($"Car Odometer {car.GetOdometer().GetMileage()} and remainder {car.GetFuelGauge().GetFuel()}");

                if (car.GetFuelGauge().GetFuel() == 0)
                {
                    while (car.GetFuelGauge().GetFuel() != car.GetTank())
                    {
                        car.GetFuelGauge().FillUp(car);
                        Console.WriteLine($"Car refueling process {car.GetFuelGauge().GetFuel()}");
                        System.Threading.Thread.Sleep(100);
                    }
                }

                System.Threading.Thread.Sleep(260);
            }
        }
    }
}
