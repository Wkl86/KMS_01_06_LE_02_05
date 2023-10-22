using System;

namespace KMS_01_06_LE_02_05
{

    public class Trapezoid
    {
        private double LengthA { get; set; }
        private double LengthC { get; set; }
        private double Width { get; set; }
        private double Height { get; set; }

        public Trapezoid(double lengthA, double lengthC, double height, double width)
        {
            LengthA = lengthA;
            LengthC = lengthC;
            Height = height;
            Width = width;
        }

        public double Area() => Math.Round(((LengthA + LengthC) / 2) * Height, 2);
        public double Scope() => ((Width * 2) + (LengthA + LengthC));
    }


}


