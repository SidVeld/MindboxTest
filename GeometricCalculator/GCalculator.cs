using System;

namespace GeometricCalculator
{

    /// <summary>
    /// Геометрический калькулятор.
    /// 
    /// На данный момент 
    /// 
    /// </summary>
    public class GCalculator
    {
        #region Methods


        /// <summary>
        /// Calculates and returns the area of the circle.
        /// </summary>
        /// <param name="circle"> The circle where you need to find the area. </param>
        /// <returns> Circle's area. </returns>
        public static double GetCircleArea(Circle circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }

        /// <summary>
        /// Calculates and returns the area of the triangle.
        /// The calculation goes on three sides.
        /// </summary>
        /// <param name="triangle"> The triangle where you need to find the area. </param>
        /// <returns> Triangle's area. </returns>
        public static double GetTriangleArea(Triangle triangle)
        {
            double a;
            double b;
            double c;

            double p;
            double S;

            a = triangle.SideA;
            b = triangle.SideB;
            c = triangle.SideC;

            p = (a + b + c) / 2;  // Half-perimetr of the triangle.

            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return S;
        }

        public static double GetSquareArea(Square square)
        {
            return square.Height * square.Width;
        }

        /// <summary>
        /// Calculates and return the area of the Unknown SHAPE.
        /// </summary>
        /// <param name="shape"> The shape where you need to find the area. </param>
        /// <returns> Shape's area. </returns>
        public static double GetBlindArea(Shape shape)
        {
            switch (shape)
            {
                case Circle circle:
                    return GetCircleArea(circle);

                case Triangle triangle:
                    return GetTriangleArea(triangle);

                case Square square:
                    return GetSquareArea(square);

                default:
                    throw new ArgumentException("Unknown shape.");

                case null:
                    throw new ArgumentException("Can't get area from null.");
            }
        }

        /// <summary>
        /// Checks if triangle is Rectangular
        /// </summary>
        /// <param name="triangle"> The triangle where you need to check Rectangularity. </param>
        /// <returns> true or false </returns>
        public static bool IsTriangleRectangular(Triangle triangle)
        {
            double a;
            double b;
            double c;

            a = triangle.SideA;
            b = triangle.SideB;
            c = triangle.SideC;

            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }

        #endregion

    }
}
