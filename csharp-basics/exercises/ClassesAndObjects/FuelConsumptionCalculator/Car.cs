namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers;
        private double _endKilometers;
        private double _liters;

        public Car(double startOdo, double endingOdo, double liters)
        {
            _startKilometers = startOdo;
            _endKilometers = endingOdo;
            _liters = liters;
        }

        public double CalculateConsumption()
        {
            return (_endKilometers - _startKilometers) / _liters;
        }

        private double ConsumptionPer100Km()
        {
            return (_endKilometers - _startKilometers / _liters) * 100;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(double mileage, double liters)
        {
            _liters += liters;
            _endKilometers += mileage;
        }
    }
}
