using System;

namespace EnergyDrinks
{
    class EnergyDrinks
    {
        int _numberedSurveyed;
        double _purchasedEnergyDrinks;

        public EnergyDrinks(int numberedSurveyed, double purchasedEnergyDrinks)
        {
            _numberedSurveyed = numberedSurveyed;
            _purchasedEnergyDrinks = purchasedEnergyDrinks;
        }

        public double CalculateEnergyDrinkers()
        {
            return Math.Floor(_purchasedEnergyDrinks * _numberedSurveyed);
        }
    }
}
