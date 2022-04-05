using System;

namespace GeometricCalculator
{
    public class Square : Shape
    {
        #region Properties

        public double Width { get; set; }
        public double Height { get; set; }

        #endregion

        #region Methods

        public Square(double width, double height)
        {
            if (Width <= 0)
                throw new ArgumentException("Width should be more then zero.");

            if (Height <= 0)
                throw new ArgumentException("Width should be more then zero.");

            Width = Height;
        }
        
        #endregion
    }
}
