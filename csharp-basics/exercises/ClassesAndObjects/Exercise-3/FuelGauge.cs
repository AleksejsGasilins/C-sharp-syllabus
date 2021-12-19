using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class FuelGauge
    {
        private int _fuel;
        

        public FuelGauge(int fuel = 0)
        {
            _fuel = fuel;
        }

        public int GetFuel()
        {
            return _fuel;
        }

        public void BurnFuel()
        {
            if (_fuel > 0)
            {
                _fuel--;
            }
        }

        public void FillUp(Car car)
        {
            if (_fuel <= car.GetTank())
            {
                _fuel++;
            }
        }
    }

}
