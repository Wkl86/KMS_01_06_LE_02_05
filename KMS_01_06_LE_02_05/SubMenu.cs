using System;

namespace KMS_01_06_LE_02_05
{
    public class SubMenu
    {
        public static void DisplaySubMenu()
        {
            int selectSubMenu = 0;

            do
            {
                try
                {
                    Console.WriteLine("Addition: (1)");
                    Console.WriteLine("Subtraktion: (2)");
                    Console.WriteLine("Multiplikation: (3)");
                    Console.WriteLine("Division: (4)");
                    Console.WriteLine("Hauptmenü: (0)");

                    selectSubMenu = Convert.ToInt32(Console.ReadLine());

                    double operand1, operand2;
                    TwoOperandCalculation Calculator;

                    switch (selectSubMenu)
                    {
                        case 1:
                            operand1 = SelectInputs.GetNumericInput("Geben Sie den ersten Operanden ein: ");
                            operand2 = SelectInputs.GetNumericInput("Geben Sie den zweiten Operanden ein: ");
                            Calculator = new TwoOperandCalculation(operand1, operand2);
                            double resultAddition = Calculator.Addition();
                            Console.WriteLine($"Die Formel für eine Addition ist: {operand1} + {operand2}");
                            Console.WriteLine($"Das Ergebnis ist: {resultAddition}");
                            break;

                        case 2:
                            operand1 = SelectInputs.GetNumericInput("Geben Sie den ersten Operanden ein: ");
                            operand2 = SelectInputs.GetNumericInput("Geben Sie den zweiten Operanden ein: ");
                            Calculator = new TwoOperandCalculation(operand1, operand2);
                            double resultSubtraction = Calculator.Subraction();
                            Console.WriteLine($"Die Formel für eine Subtraktion ist: {operand1} - {operand2}");
                            Console.WriteLine($"Das Ergebnis ist: {resultSubtraction}");
                            break;

                        case 3:
                            operand1 = SelectInputs.GetNumericInput("Geben Sie den ersten Operanden ein: ");
                            operand2 = SelectInputs.GetNumericInput("Geben Sie den zweiten Operanden ein: ");
                            Calculator = new TwoOperandCalculation(operand1, operand2);
                            double resultMultiplication = Calculator.Multiplication();
                            Console.WriteLine($"Die Formel für eine Multiplikation ist: {operand1} * {operand2}");
                            Console.WriteLine($"Das Ergebnis ist: {resultMultiplication}");
                            break;

                        case 4:
                            operand1 = SelectInputs.GetNumericInput("Geben Sie den ersten Operanden ein: ");
                            operand2 = SelectInputs.GetNumericInput("Geben Sie den zweiten Operanden ein: ");
                            Calculator = new TwoOperandCalculation(operand1, operand2);
                            double resultDivision = Calculator.Division();
                            Console.WriteLine($"Die Formel für eine Division ist: {operand1} / {operand2}");
                            Console.WriteLine($"Das Ergebnis ist: {resultDivision}");
                            break;

                        case 0:
                            Console.WriteLine("Zurück zum Hauptmenü");
                            break;

                        default:
                            Console.WriteLine("Ungültige Eingabe!");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Formatfehler: " + ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Division durch Null ist nicht erlaubt: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ein Fehler ist aufgetreten: " + ex.Message);
                }
            } while (selectSubMenu != 0);
        }
    }
}
