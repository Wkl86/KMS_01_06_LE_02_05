using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Console.WriteLine("Addition:  (1) ");
                    Console.WriteLine("Subtraktion: (2) ");
                    Console.WriteLine("Multiplikation: (3) ");
                    Console.WriteLine("Division: (4): ");
                    Console.WriteLine("Hauptmenü: (0) ");

                    selectSubMenu = Convert.ToInt32(Console.ReadLine());

                    switch (selectSubMenu)
                    {
                        case 1:
                            double summand1 = SelectInputs.GetNumericInput("Geben Sie den ersten Summanden ein:");
                            double summand2 = SelectInputs.GetNumericInput("Geben Sie den zweiten Summanden ein:");
                            double resultAddition = Calculations.Addition(summand1, summand2);
                            Console.WriteLine($"Die Formel für eine Addition ist: {summand1} + {summand2}");
                            Console.WriteLine($"Das Ergebnis ist: {resultAddition}");
                            break;

                        case 2:
                            double minuend = SelectInputs.GetNumericInput("Geben Sie den Minuend ein:");
                            double subtrahend = SelectInputs.GetNumericInput("Geben Sie den Subtrahend ein:");
                            double resultSubtraction = Calculations.Subraction(minuend, subtrahend);
                            Console.WriteLine($"Die Formel für eine Subtraktion ist: {minuend} - {subtrahend}");
                            Console.WriteLine($"Das Ergebnis ist: {resultSubtraction}");
                            break;

                        case 3:
                            double factor1 = SelectInputs.GetNumericInput("Geben Sie den ersten Faktor ein:");
                            double factor2 = SelectInputs.GetNumericInput("Geben Sie den zweiten Faktor ein:");
                            double resultMultiplication = Calculations.Multiplication(factor1, factor2);
                            Console.WriteLine($"Die Formel für eine Multiplikation ist: {factor1} * {factor2}");
                            Console.WriteLine($"Das Ergebnis ist: {resultMultiplication}");
                            break;

                        case 4:
                            double divisor = SelectInputs.GetNumericInput("Geben Sie den Divisor ein (nicht 0):");
                            double dividend = SelectInputs.GetNumericInput("Geben Sie den Dividend ein:");
                            double resultDivision = Calculations.Division(divisor, dividend);
                            Console.WriteLine($"Die Formel für eine Division ist: {divisor} / {dividend}");
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
                    Console.WriteLine(ex.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            } while (selectSubMenu != 0);
        }

    }
}
