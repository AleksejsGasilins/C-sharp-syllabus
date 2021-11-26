using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravity = -9.81d;  // Earth's gravity in m/s^2
            double initialVelocity = 0.0d;
            double fallingTime = 10.0d;
            double initialPosition = 0.0d;
            double finalPosition = 0.0d;

            finalPosition = 0.5 * gravity * (fallingTime * fallingTime) + initialVelocity * fallingTime + initialPosition;
            Convert.ToDecimal(finalPosition);
            

            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }
}
