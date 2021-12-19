namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers;
        private double _endKilometers = 0;
        private double _liters = 0;

        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return ((_endKilometers - _startKilometers) / _liters) * 100;
        }

        public bool GasHog()
        {
            return CalculateConsumption() > 15;
        }

        public bool EconomyCar()
        {
            return CalculateConsumption() < 5;
        }

        public void FillUp(double mileage, double liters)
        {
            _liters += liters;
            _endKilometers += mileage;
        }
    }
}
