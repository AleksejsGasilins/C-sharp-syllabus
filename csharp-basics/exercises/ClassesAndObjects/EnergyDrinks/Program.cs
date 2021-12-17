using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        public static void Main(string[] args)
        {
            EnergyDrinks energyDrinks = new EnergyDrinks(NumberedSurveyed, PurchasedEnergyDrinks);
            CitrusFlavored citrusFlavored = new CitrusFlavored(NumberedSurveyed, PurchasedEnergyDrinks, PreferCitrusDrinks);

            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed); 
            Console.WriteLine("Approximately " + energyDrinks.CalculateEnergyDrinkers() + " bought at least one energy drink"); 
            Console.WriteLine(citrusFlavored.CalculateEnergyCitrusDrinkers() + " of those " + "prefer citrus flavored energy drinks."); 
            Console.ReadKey();
        }
    }
}
