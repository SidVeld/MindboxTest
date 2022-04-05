using System;

namespace GeometricCalculator
{
    public class Circle : Shape
    {
        #region Properties

        public double Radius { get; set; }
        public double Diameter { get { return Radius * 2; } }

        #endregion

        #region Methods

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius should be more then zero.");

            Radius = radius;
        }
        
        #endregion
    }
}
