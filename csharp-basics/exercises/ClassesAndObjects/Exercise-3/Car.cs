using System;

namespace Exercise_3
{
    public class Car
    {
       int _tank;
       private FuelGauge _fuelGauge;
       private Odometer _odometer;

         public Car(int tank, FuelGauge fuelGauge, Odometer odometer)
         {
             _tank = tank;
             _fuelGauge = fuelGauge;
             _odometer = odometer;
         }

         public int GetTank()
         {
             return _tank;
         }

         public FuelGauge GetFuelGauge()
         {
             return _fuelGauge;
         }

         public Odometer GetOdometer()
         {
             return _odometer;
         }
    }
}
