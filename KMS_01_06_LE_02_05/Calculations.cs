using System;

namespace KMS_01_06_LE_02_05
{
    public class Calculations
    {
        /*
         * Die Codeverkürzung erfolgte mittels Lamda-Funktion
         */
        public static double Addition(double summand1, double summand2) => summand1 + summand2;
        public static double Subtraction(double minuend, double subtrahend) => minuend - subtrahend;
        public static double Multiplication(double factor1, double factor2) => Math.Round(factor1 * factor2, 2);
        public static double Division(double divisor, double divident) => divisor == 0 ? 0 : Math.Round(divisor / divident, 2);
        public static double Modulo(double divisor, double divident) => divisor == 0 ? 0 : Math.Round(divisor % divident, 2);
        public static double Cubed2(double basis) =>  Math.Round((double) Math.Pow(basis, 2), 2);
        public static double Cubed3(double basis) => Math.Round((double)Math.Pow(basis, 3), 2);
        public static double SquareRoot(double radikand) => Math.Round(Math.Sqrt(radikand), 2);
        public static double Factorial(double n) => n == 0 ? 1 : n * Factorial(n - 1);
        public static double Trapezoid(double lengthA, double lengthC, double height) => Math.Round(((lengthA + lengthC) / 2) * height, 2);
        public static double Trapezoid(double lengthA, double lengthB, double lengthC, double lengthD) => lengthA + lengthB + lengthC + lengthD;
        public static double VolumeBall(double radius) => Math.Round((4.0 / 3.0) * Math.PI * Math.Pow(radius, 3), 2);
    }

}