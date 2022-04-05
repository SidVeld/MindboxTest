using System;
using GeometricCalculator;

namespace TestingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double circleRadius;
            double sideA;
            double sideB;
            double sideC;

            Console.WriteLine("GEOMETRIC CALCULATOR\n\n");

            // -----

            Console.Write("Testing Circle. Please, input radius: ");
            circleRadius = Convert.ToDouble(Console.ReadLine());
            Circle circle = new(circleRadius);

            Console.WriteLine("Circle radius: " + circle.Radius);
            Console.WriteLine("Circle diametr: " + circle.Diameter);
            Console.WriteLine("Circle area: " + GCalculator.GetCircleArea(circle));

            // -----

            Console.WriteLine("\n");

            Console.Write("Testing Triangle. Please, input Side A: ");
            sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Testing Triangle. Please, input Side B: ");
            sideB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Testing Triangle. Please, input Side C: ");
            sideC = Convert.ToDouble(Console.ReadLine());
            Triangle triangle = new(sideA, sideB, sideC);

            Console.WriteLine("Triangle side A: " + triangle.SideA);
            Console.WriteLine("Triangle side B: " + triangle.SideB);
            Console.WriteLine("Triangle side C: " + triangle.SideC);
            Console.WriteLine("Triangle Area: " + GCalculator.GetTriangleArea(triangle));
            Console.WriteLine("Triangle Ractegular: " + GCalculator.IsTriangleRectangular(triangle));

            // -----

            Console.WriteLine("\n");

            Console.WriteLine("Now we gonna try to find area of two figures");
            Console.WriteLine("First we try to find radius of circle.");
            Console.WriteLine("After that we try to find radius of triangle.");
            Console.WriteLine("Calculator doesn't know type of shape.\n");

            Console.Write("Testing Shape (Circle). Please, input radius: ");
            circleRadius = Convert.ToDouble(Console.ReadLine());
            Circle BlindedCircle = new(circleRadius);
            Console.WriteLine("Area of this Circle: " + GCalculator.GetBlindArea(BlindedCircle));

            // -----

            Console.Write("Testing Triangle. Please, input Side A: ");
            sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Testing Triangle. Please, input Side B: ");
            sideB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Testing Triangle. Please, input Side C: ");
            sideC = Convert.ToDouble(Console.ReadLine());
            Triangle BlindedTriangle = new(sideA, sideB, sideC);
            Console.WriteLine("Area of this Shape (Circle): " + GCalculator.GetBlindArea(BlindedTriangle));
        }
    }
}
