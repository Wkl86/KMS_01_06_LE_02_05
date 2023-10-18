using KMS_01_06_LE_02_05;
using System;

namespace KMS_01_06_LE_02_04
{
    public class Menu
    {

        public static void Selects()
        {

            int select = 0;

            do
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
                try
                {
                    select = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe!");
                    continue;
                }

                switch (select)
                {
                    case 1:
                        DisplaySubMenu();

                        break;

                    case 2:
                        double divisor = GetNumericInput("Geben Sie den Divisor ein:");
                        double divident = GetNumericInput("Geben Sie den Divident ein:");
                        double resultModula = Calculations.Division(divisor, divident);
                        Console.WriteLine("Die Formel für eine Moduladivison lt. divisor % divident");
                        Console.WriteLine($"Das Ergebnis von {divisor} % {divident} = {resultModula}");
                        break;
                    case 3:
                        double basis = GetNumericInput("Geben Sie die Basis ein:");
                        double resultPotenz2 = Calculations.Potenz2(basis);
                        Console.WriteLine("Die Formel für eine Quadrierung lt. basis * basis");
                        Console.WriteLine($"Das Ergebnis von {basis} * {basis} = {resultPotenz2}");
                        break;
                    case 4:
                        double basis1 = GetNumericInput("Geben Sie die Basis ein:");
                        double resultPotenz3 = Calculations.Potenz3(basis1);
                        Console.WriteLine("Die Formel für eine Berechnung Basis hoch 3 lt. basis * basis * basis ");
                        Console.WriteLine($"Das Ergebnis von {basis1} * {basis1} * {basis1} = {resultPotenz3}");
                        break;
                    case 5:
                        double radikand = GetNumericInput("Geben Sie den Radikand ein:");
                        double resultSQRT = Calculations.SquareRoot(radikand);
                        Console.WriteLine("Die Formel für eine Wurzelziehung zum Quadrat lt. √ aus radikand");
                        Console.WriteLine($"Das Ergebnis von √ {radikand} = {resultSQRT}");
                        break;
                    case 6:
                        int n = GetIntInput("Geben Sie für n eine Zahl ein: ");
                        double resultFactorial = Calculations.Factorial(n);
                        Console.WriteLine("Die Formel von der Falultät ! n = n! * ∑ k = O n(-1)k k!");
                        Console.WriteLine($"Das Ergebnis von  {n}! = {resultFactorial}");
                        break;
                    case 7:
   
                        double lengthA = GetNumericInput("Geben Sie die Länge a ein:");
                        double lengthC = GetNumericInput("Geben Sie die Länge c ein:");
                        double height = GetNumericInput("Geben Sie die Höhe ein:");
                        double resultAreaTrapezoid = Calculations.Trapezoid(lengthA, lengthC, height);
                        Console.WriteLine("Die Formel der Flächenberechnung eines Trapezes ist: ((Länge A + Länge C) / 2 * Höhe))");
                        Console.WriteLine($"Das Ergebnis von  (({lengthA} + {lengthC}) / 2 * {height})) = {resultAreaTrapezoid} in m²");
                        break;
                    case 8:

                        double lengthA1 = GetNumericInput("Geben Sie die Länge a ein:");
                        double lengthB = GetNumericInput("Geben Sie die Länge b ein:");
                        double lengthC1 = GetNumericInput("Geben Sie die Länge c ein:");
                        double lengthD = GetNumericInput("Geben Sie die Länge d ein:");
                        double resultScopeTrapezoid = Calculations.Trapezoid(lengthA1, lengthB, lengthC1, lengthD);
                        Console.WriteLine("Die Formel der Umfangberechnung eines Trapezes ist: Länge A + Länge B + Länge C + Länge D");
                        Console.WriteLine($"Das Ergebnis von  (({lengthA1} + {lengthB} + {lengthC1} + {lengthD} = {resultScopeTrapezoid} in m");
                        break;
                    case 9:
                        double radius = GetNumericInput("Geben Sie den Radius ein:");
                        double resultVolumeBall = Calculations.VolumeBall(radius);
                        Console.WriteLine("Die Formel der Volumsberechnung einer Kugel ist:(4 / 3) * PI * radius³");
                        Console.WriteLine($"Das Ergebnis von (4 / 3) * PI * {radius}³ = {resultVolumeBall} in m³");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Falsche Eingabe");
                        continue;
                }

            } while (true);
        }
        public static void DisplaySubMenu()
        {
            int selectSubMenu = 0;

            do
            {
                Console.WriteLine("Addition:  (1) ");
                Console.WriteLine("Subraktion: (2) ");
                Console.WriteLine("Multiplikation: (3) ");
                Console.WriteLine("Division: (4): ");
                Console.WriteLine("Hauptmenü: (0) ");

                try
                {
                    selectSubMenu = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe!");
                    continue;
                }
                switch (selectSubMenu)
                {
                    case 1:
                        double summand1 = GetNumericInput("Geben Sie den Summanden ein:");
                        double summand2 = GetNumericInput("Geben Sie den Summanden ein:");
                        double resultAddition = Calculations.Addition(summand1, summand2);
                        Console.WriteLine("Die Formel für eine Addition lt. summand1 + summand2");
                        Console.WriteLine($"Das Ergebnis ist: {summand1} + {summand2} = {resultAddition}");
                        break;

                    case 2:
                        double minuend = GetNumericInput("Geben Sie den Minunden ein:");
                        double subtrahend = GetNumericInput("Geben Sie den Subtrahenden ein:");
                        double resultSubraction = Calculations.Subraction(minuend, subtrahend);
                        Console.WriteLine("Die Formel für eine Addition lt. minuend - subtrahend");
                        Console.WriteLine($"Das Ergebnis ist: {minuend} - {subtrahend} = {resultSubraction}");
                        break;
                    case 3:
                        double factor1 = GetNumericInput("Geben Sie den ersten Faktor ein:");
                        double factor2 = GetNumericInput("Geben Sie den zweiten Faktor ein:");
                        double resultMultipliaction = Calculations.Multiplication(factor1, factor2);
                        Console.WriteLine("Die Formel für eine Multiplication lt. factor1 * factor2");
                        Console.WriteLine($"Das Ergebnis ist: {factor1} * {factor2} = {resultMultipliaction}");
                        break;
                    case 4:
                        double divisor = GetNumericInput("Geben Sie den Divisor ein, nicht 0!");
                        double divident = GetNumericInput("Geben Sie den Dividenten ein:");
                        double resultDivison = Calculations.Division(divisor, divident);
                        Console.WriteLine("Die Formel für eine Multiplication lt. divisor / divident");
                        Console.WriteLine($"Das Ergebnis ist: {divisor} / {divident} = {resultDivison}");
                        break;
                    case 0:
                        Console.WriteLine("Zurück zum Hauptmenü");
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe!");
                        continue;
                }
            } while (selectSubMenu != 0);
        }
        public static double GetNumericInput(string input)
        {
            double value = 0;
            bool checkInput = false;

            while (!checkInput)
            {
                Console.WriteLine(input);
                string inputUser = Console.ReadLine();
                if (double.TryParse(inputUser, out double numericValue))
                {
                    value = numericValue;
                    checkInput = true;
                }
                else
                {
                    Console.WriteLine("Geben Sie eine gültige numerische Zahl ein:");
                }
            }
            return value;
        }
        public static int GetIntInput(string input)
        {
            int value = 0;
            bool checkInput = false;

            while (!checkInput)
            {
                Console.WriteLine(input);
                string inputUser = Console.ReadLine();
                if (int.TryParse(inputUser, out int intValue))
                {
                    value = intValue;
                    checkInput = true;
                }
                else
                {
                    Console.WriteLine("Geben Sie eine gültige Ganzzahl ein!");
                }
            }
            return value;
        }
    }
}