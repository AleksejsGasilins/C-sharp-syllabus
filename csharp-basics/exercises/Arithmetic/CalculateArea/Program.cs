using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (GetMenu())
            {
                case 1:
                    CalculateCircleArea();
                    break;
                case 2:
                    CalculateRectangleArea();
                    break;
                case 3:
                    CalculateTriangleArea();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Error data");
                    Console.ReadKey();
                    break;
            }
        }

        public static int GetMenu()
        {
            int userChoice = 0;
            
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();

            if (char.IsDigit(keyboard.KeyChar))
            {
                return int.Parse(keyboard.KeyChar.ToString());
            }

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            decimal radius = 0m;

            Console.WriteLine();
            Console.WriteLine("What is the circle's radius? ");
            string inputRadius = Console.ReadLine();
            radius = Convert.ToDecimal(inputRadius);

            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
            Console.ReadKey();
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0m;
            decimal width = 0m;

            Console.WriteLine();
            Console.WriteLine("Enter length? ");
            string inputLenght = Console.ReadLine();
            length = Convert.ToDecimal(inputLenght);

            Console.WriteLine("Enter width? ");
            string inputWidth = Console.ReadLine();
            width = Convert.ToDecimal(inputWidth);

            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
            Console.ReadKey();
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0m;
            decimal height = 0m;

            Console.WriteLine();
            Console.WriteLine("Enter length of the triangle's base? ");
            string inputGround = Console.ReadLine();
            ground = Convert.ToDecimal(inputGround);
            Console.WriteLine("Your base is " + ground);

            Console.WriteLine("Enter triangle's height? ");
            string inputHeight = Console.ReadLine();
            height = Convert.ToDecimal(inputHeight);
            Console.WriteLine("Triangles height is " + height);

            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
            Console.ReadKey();
        }
    }
}
