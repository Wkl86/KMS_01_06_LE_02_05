using System;

namespace KMS_01_06_LE_02_05
{
    public class Calculations
    {

        public static double Addition(double summand1, double summand2)
        {
            return summand1 + summand2;

        }

        public static double Subraction(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public static double Multiplication(double factor1, double factor2)
        {
            double result = Math.Round(factor1 * factor2, 2);
            return result;
        }
  
        public static double Division(double divisor, double divident)
        {
            if (divisor == 0)
            {
                return 0;
            }
            double result = Math.Round(divisor / divident, 2);
            return result;
        }
        public static double Modula(double divisor, double divident)
        {
            if (divisor == 0)
            {
                return 0;
            }
            double result = Math.Round(divisor % divident, 2);
            return result;
        }

        public static double Potenz2(double basis)
        {
            double area = Math.Round((double)Math.Pow(basis, 2), 2);
            return area;
        }
     
        
        public static double Potenz3(double basis)
        {
            double volume = Math.Round((double)Math.Pow(basis, 3), 2);
            return volume;
        }
        public static double SquareRoot(double radikand)
        {
            double result = Math.Round(Math.Sqrt(radikand), 2);
            return result;
        }

        public static int Factorial(int n)

        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        public static double Trapezoid(double lenghtA, double lenghtC, double height)
        {

            double result = Math.Round(((lenghtA + lenghtC) / 2) * height, 2);
            return result;
        }


        public static double Trapezoid(double lenghtA, double lenghtB, double lenghtC, double lenghtD)
        {

            double result = lenghtA + lenghtB + lenghtC + lenghtD;
            return result;
        }

        public static double VolumeBall(double radius)
        {
            double result = Math.Round((4.0 / 3.0) * Math.PI * Math.Pow(radius, 3), 2);
            return result;
        }
    }
}