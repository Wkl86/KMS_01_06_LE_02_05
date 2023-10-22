using System;

namespace KMS_01_06_LE_02_05
{
    public class TwoOperandCalculation

    {
        private double Operand1 { set; get; }
        private double Operand2 { set; get; }

        public TwoOperandCalculation()
        {
            Operand1 = 0;
            Operand2 = 0;
        }

        public TwoOperandCalculation(double operand1, double operand2)
        {
            Operand1 = operand1;
            Operand2 = operand2;

        }

        public double Addition() => Operand1 + Operand2;
        public double Subraction() => Operand1 - Operand2;
        public double Multiplication() => Math.Round(Operand1 * Operand2, 2);
        public double Division() => Operand1 == 0 ? 0 : Math.Round(Operand1 / Operand2, 2);
        public double Modulo() => Operand1 == 0 ? 0 : Math.Round(Operand1 % Operand2, 2);
    }
}
