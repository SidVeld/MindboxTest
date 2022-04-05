using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricCalculator;
using System;

namespace Test
{
    [TestClass]
    public class TestingCalculator
    {
        [TestMethod]
        public void TestCircle()
        {
            double[] radii = { 0.5, 1.0, 1.5, 2.0, 2.5, 3.0 };
            Circle circle = new(1);
            foreach (double radius in radii)
            {
                circle.Radius = radius;
                double result = Math.PI * Math.Pow(circle.Radius, 2);
                double calculatorResult = GCalculator.GetCircleArea(circle);
                string message = "Calculator: " + calculatorResult + " Should be:" + result;
                Assert.AreEqual(calculatorResult, result, 0.01, message);
            }
        }

        [TestMethod]
        public void TestTriangle()
        {
            double[,] sides = {
                { 3, 4, 5 }, { 6, 6, 6 }, { 5, 5, 7 },
                { 7, 9, 6 }, { 9, 5, 6 }, { 2, 4, 3 }
            };
            Triangle triangle = new(1, 1, 1);
            for (int index = 0; index < sides.GetLength(0); index++)
            {
                triangle.SideA = sides[index, 0];
                triangle.SideB = sides[index, 1];
                triangle.SideC = sides[index, 2];

                double p = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
                double result = Math.Sqrt(p * (p - triangle.SideA) * (p - triangle.SideB) * (p - triangle.SideC));
                double calculatorResult = GCalculator.GetTriangleArea(triangle);
                string message = "Calculator: " + calculatorResult + " Should be:" + result;
                Assert.AreEqual(calculatorResult, result, 0.01, message);
            }
        }
    }
}
