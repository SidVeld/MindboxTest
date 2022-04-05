using System;


namespace GeometricCalculator
{
    public class Triangle : Shape
    {

        #region Properties

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public bool Rectangular { get; }
        public bool Equilateral { get; }
        
        #endregion

        #region Methods

        public Triangle(double sideA, double sideB, double sideC)
        {
            CheckTriangle(sideA, sideB, sideC);

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            Rectangular = IsRectangular(sideA, sideB, sideC);
            Equilateral = IsEquilateral(sideA, sideB, sideC);
        }

        private static void CheckTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB <= sideC)
                throw new ArgumentException("Summ of Side A and Side B should be more than side C");
            
            if (sideA + sideC <= sideB)
                throw new ArgumentException("Summ of Side A and Side C should be more than side B");
            
            if (sideB + sideC <= sideA)
                throw new ArgumentException("Summ of Side B and Side C should be more than side A");
        }

        private static bool IsRectangular(double sideA, double sideB, double sideC)
        {
            return Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2);
        }

        private static bool IsEquilateral(double sideA, double sideB, double sideC)
        {
            return (sideA == sideB) && (sideB == sideC) && (sideC == sideA);
        }

        #endregion
    }
}
