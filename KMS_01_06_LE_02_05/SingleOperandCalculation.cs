using System;

namespace KMS_01_06_LE_02_05
{
    public class SingleOperandCalculation
    {
        private double Operand1 { set; get; }
        public SingleOperandCalculation()
        {
            Operand1 = 0.0;
        }

        public SingleOperandCalculation(double operand1)
        {
            Operand1 = operand1 ;
        }

        public double Cubed2() => Math.Round((double)Math.Pow(Operand1, 2), 2);
        public double Cubed3() => Math.Round((double)Math.Pow(Operand1, 3), 2);
        public double SquareRoot() => Math.Round(Math.Sqrt(Operand1), 2);
        public double Factorial()
        {
            if (Operand1 == 0)
            {
                return 1;
            }
            else
            {
                double result = 1;
                for (int i = 1; i <= Operand1; i++)
                {
                    result *= i;
                }
                return result;
            }
        }

        public double VolumeBall() => Math.Round((4.0 / 3.0) * Math.PI * Math.Pow(Operand1, 3), 2);

    }
}