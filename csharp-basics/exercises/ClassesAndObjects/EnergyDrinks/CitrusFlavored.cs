using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class CitrusFlavored
    {
        int _numberedSurveyed;
        double _purchasedEnergyDrinks;
        double _preferCitrusDrinks;

        public CitrusFlavored(int numberedSurveyed, double purchasedEnergyDrinks, double preferCitrusDrinks)
        {
            _numberedSurveyed = numberedSurveyed;
            _purchasedEnergyDrinks = purchasedEnergyDrinks;
            _preferCitrusDrinks = preferCitrusDrinks;
        }

        public double CalculateEnergyCitrusDrinkers()
        {
            return Math.Floor(_purchasedEnergyDrinks * _numberedSurveyed * _preferCitrusDrinks);
        }
    }
}
