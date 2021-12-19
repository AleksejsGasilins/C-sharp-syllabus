using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Odometer
    {
        public int _mileage;

        public Odometer(int startKm = 0)
        {
            _mileage = startKm;
        }

        public int GetMileage()
        {
            return _mileage;
        }

        public void Drive(FuelGauge fuelGauge)
        {
            if (fuelGauge.GetFuel() > 0)
            {
                AddMileage(10);

                fuelGauge.BurnFuel();
            }
        }

        public void AddMileage(int km = 1)
        {
            _mileage += km;

            if (_mileage > 999999)
            {
                _mileage = 0;
            }
        }
    }
}
