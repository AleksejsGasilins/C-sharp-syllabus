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
            double CarpoolCapacity;
            double AveragePassengersPerCar;

            Cars = 100; //cars
            SeatsInACar = 4.0; //seats in a car
            Drivers = 28; // drivers
            Passengers = 90; // passengers
            CarsNotDriven = 72;  // free cars
            CarsDriven = ; // cars driven at the moment
            CarpoolCapacity = ;// carpool capacity
            AveragePassengersPerCar = 4;// average passengers per car

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