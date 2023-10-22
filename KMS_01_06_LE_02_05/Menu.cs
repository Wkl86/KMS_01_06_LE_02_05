using KMS_01_06_LE_02_05;
using System;
using System.IO;

namespace KMS_01_06_LE_02_04
{
    public class Menu
    {
        public void Selects()
        {
            int select = 0;
            double operand1, operand2, lengthA, lengthC, height, width;
            SingleOperandCalculation CalcOneOperand;
            TwoOperandCalculation CalcTwoOperands;
            Trapezoid CalcArea;
            Trapezoid CalcScope;

            do
            {
                try
                {
                    Console.WriteLine("Grundrechnungsarten ( +, - , * , / ): (1): ");
                    Console.WriteLine("Modula: (2)");
                    Console.WriteLine("Berechnung x²: (3) ");
                    Console.WriteLine("Berechnung x³: (4) ");
                    Console.WriteLine("Berechnung sqrt²: (5) ");
                    Console.WriteLine("Berechnung Fakultät: (6) ");
                    Console.WriteLine("Berechnung Fläche eines Trapezes: (7) ");
                    Console.WriteLine("Berechnung Umfang eines Trapezes: (8) ");
                    Console.WriteLine("Berechung des Volumen einer Kugel: (9) ");
                    Console.WriteLine("Beenden des Programmes: (0) ");
                    select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            SubMenu.DisplaySubMenu();
                            break;

                        case 2:
                            operand1 = SelectInputs.GetNumericInput("Geben Sie den ersten Operanden ein: ");
                            operand2 = SelectInputs.GetNumericInput("Geben Sie den zweiten Operanden ein: ");
                            CalcTwoOperands = new TwoOperandCalculation(operand1, operand2);
                            double resultModulo = CalcTwoOperands.Modulo();
                            Console.WriteLine("Die Formel für eine Moduladivison lt. divisor % divident");
                            Console.WriteLine($"Das Ergebnis von {operand1} % {operand2} = {resultModulo}");
                            break;
                        case 3:
                            operand1 = SelectInputs.GetNumericInput("Geben Sie den Operanden ein: ");
                            CalcOneOperand = new SingleOperandCalculation(operand1);
                            double resultCubed2 = CalcOneOperand.Cubed2();
                            Console.WriteLine("Die Formel für eine Quadrierung lt. basis * basis");
                            Console.WriteLine($"Das Ergebnis von {operand1} * {operand1} = {resultCubed2}");
                            break;
                        case 4:
                            operand1 = SelectInputs.GetNumericInput("Geben Sie den Operanden ein: ");
                            CalcOneOperand = new SingleOperandCalculation(operand1);
                            double resultCubed3 = CalcOneOperand.Cubed3();
                            Console.WriteLine("Die Formel für eine Berechnung Basis hoch 3 lt. basis * basis * basis");
                            Console.WriteLine($"Das Ergebnis von {operand1} * {operand1} * {operand1} = {resultCubed3}");
                            break;
                        case 5:
                            operand1 = SelectInputs.GetNumericInput("Geben Sie den Operanden ein: ");
                            CalcOneOperand = new SingleOperandCalculation(operand1);
                            double resultSQRT = CalcOneOperand.SquareRoot();
                            Console.WriteLine("Die Formel für eine Wurzelziehung zum Quadrat lt. √ aus radikand");
                            Console.WriteLine($"Das Ergebnis von √ {operand1} = {resultSQRT}");
                            break;
                        case 6:
                            operand1 = SelectInputs.GetNumericInput("Geben Sie den Operanden ein: ");
                            CalcOneOperand = new SingleOperandCalculation(operand1);
                            double resultFactorial = CalcOneOperand.Factorial();
                            Console.WriteLine("Die Formel von der Fakultät ist: !n = n! * ∑ k = 0 n(-1)kk!");
                            Console.WriteLine($"Das Ergebnis von {operand1}! = {resultFactorial}");
                            break;
                        case 7:
                            lengthA = SelectInputs.GetNumericInput("Geben Sie die Länge a ein: ");
                            lengthC = SelectInputs.GetNumericInput("Geben Sie die Länge c ein: ");
                            height = SelectInputs.GetNumericInput("Geben Sie die Höhe ein: ");
                            width = 0;
                            CalcArea = new Trapezoid(lengthA, lengthC, height, width) ;
                            double resultAreaTrapezoid = CalcArea.Area();
                            Console.WriteLine("Die Formel der Flächenberechnung eines Trapezes ist: ((Länge A + Länge C) / 2 * Höhe)");
                            Console.WriteLine($"Das Ergebnis von  (({lengthA} + {lengthC}) / 2 * {height}) = {resultAreaTrapezoid}");
                            break;
                        case 8:
                            lengthA = SelectInputs.GetNumericInput("Geben Sie die Länge a ein: ");
                            lengthC = SelectInputs.GetNumericInput("Geben Sie die Länge c ein: ");
                            width = SelectInputs.GetNumericInput("Geben Sie die Breite c ein: ");
                            height = 0;
                            CalcScope = new Trapezoid(lengthA, lengthC, height, width);
                            double resultScopeTrapezoid = CalcScope.Scope();
                            Console.WriteLine("Die Formel der Umfangberechnung eines Trapezes ist: (2x die Breite) + (Länge A + Länge C)");
                            Console.WriteLine($"Das Ergebnis von der Umfangberechnung ist  {2 * width} + {(lengthA + lengthC)}  = {resultScopeTrapezoid}");
                            break;
                        case 9:
                            operand1 = SelectInputs.GetNumericInput("Geben Sie den Radius der Kugel ein: ");
                            CalcOneOperand = new SingleOperandCalculation(operand1);
                            double resultVolumeBall = CalcOneOperand.VolumeBall();
                            Console.WriteLine("Die Formel der Volumsberechnung einer Kugel ist: (4 / 3) * PI * radius³");
                            Console.WriteLine($"Das Ergebnis von (4 / 3) * PI * {operand1}³ = {resultVolumeBall}");
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Falsche Eingabe");
                            continue;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            } while (true);
        }
    }
}
