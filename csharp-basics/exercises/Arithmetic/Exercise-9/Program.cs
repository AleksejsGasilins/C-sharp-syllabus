using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            BMI(198, 78.74);
            BMI(308, 66.93);
            BMI(88, 64.96);
        }

        static void BMI(double weightInFt, double heightInDuim)
        {
            double weightInFtToKg = weightInFt / 2.2046;
            double heightInDuimToM = heightInDuim * 2.54 / 100;

            double FormulaBMI = weightInFtToKg / (heightInDuimToM * heightInDuimToM);
            double BMIresult = Math.Round(FormulaBMI, 2);


            if (FormulaBMI > 18.5 && FormulaBMI < 25)
            {
                Console.WriteLine(BMIresult);
                Console.WriteLine("A sedentary person's weight.");
            }
            else if (FormulaBMI < 18.5)
            {
                Console.WriteLine(BMIresult);
                Console.WriteLine("The person is considered underweight.");
            } 
            else if (FormulaBMI > 25)
            {
                Console.WriteLine(BMIresult);
                Console.WriteLine("The person is considered overweight.");
            }
        }
    }
}
