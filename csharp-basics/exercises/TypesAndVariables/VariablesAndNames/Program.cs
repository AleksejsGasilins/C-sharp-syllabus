using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int Cars;
            int Drivers;
            int Passengers;
            int CarsNotDriven; 
            int CarsDriven;
            double SeatsInACar;
            int CarpoolCapacity;
            int AveragePassengersPerCar;

            Cars = 100;
            SeatsInACar = 4.00;
            Drivers = 28;
            Passengers = 90;
            CarsNotDriven = 72;
            // free cars
            CarsDriven = 28; 
            // cars driven at the moment
            CarpoolCapacity = 60;
            AveragePassengersPerCar = 4;

            Console.WriteLine("There are " + Cars + " cars available.");
            Console.WriteLine("There are only " + Drivers + " drivers available.");
            Console.WriteLine("There will be " + CarsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + CarpoolCapacity + " people today.");
            Console.WriteLine("We have " + Passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + AveragePassengersPerCar + " in each car.");
            Console.ReadKey();
        }
    }
}