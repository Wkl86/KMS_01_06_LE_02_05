    using KMS_01_06_LE_02_05;
    using System;
    using System.IO;

namespace KMS_01_06_LE_02_04
{
    public class Menu
    {
        public static void Selects()
        {
            int select = 0;
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
                            double divisor = SelectInputs.GetNumericInput("Geben Sie den Divisor ein:");
                            double dividend = SelectInputs.GetNumericInput("Geben Sie den Divident ein:");
                            double resultModulo = Calculations.Modulo(divisor, dividend);
                            Console.WriteLine("Die Formel für eine Moduladivison lt. divisor % divident");
                            Console.WriteLine($"Das Ergebnis von {divisor} % {dividend} = {resultModulo}");
                            break;
                        case 3:
                            double basis = SelectInputs.GetNumericInput("Geben Sie die Basis ein:");
                            double resultCubed2 = Calculations.Cubed2(basis);
                            Console.WriteLine("Die Formel für eine Quadrierung lt. basis * basis");
                            Console.WriteLine($"Das Ergebnis von {basis} * {basis} = {resultCubed2}");
                            break;
                        case 4:
                            double basis1 = SelectInputs.GetNumericInput("Geben Sie die Basis ein:");
                            double resultCubed3 = Calculations.Cubed3(basis1);
                            Console.WriteLine("Die Formel für eine Berechnung Basis hoch 3 lt. basis * basis * basis ");
                            Console.WriteLine($"Das Ergebnis von {basis1} * {basis1} * {basis1} = {resultCubed3}");
                            break;
                        case 5:
                            double radikand = SelectInputs.GetNumericInput("Geben Sie den Radikand ein:");
                            double resultSQRT = Calculations.SquareRoot(radikand);
                            Console.WriteLine("Die Formel für eine Wurzelziehung zum Quadrat lt. √ aus radikand");
                            Console.WriteLine($"Das Ergebnis von √ {radikand} = {resultSQRT}");
                            break;
                        case 6:
                            double n = SelectInputs.GetNumericInput("Geben Sie für n eine Zahl ein: ");
                            double resultFactorial = Calculations.Factorial(n);
                            Console.WriteLine("Die Formel von der Fakultät ist: !n = n! * ∑ k = O n(-1)kk!");
                            Console.WriteLine($"Das Ergebnis von  {n}!  {resultFactorial}");
                            break;
                        case 7:
                            double lengthA = SelectInputs.GetNumericInput("Geben Sie die Länge a ein:");
                            double lengthC = SelectInputs.GetNumericInput("Geben Sie die Länge c ein:");
                            double height = SelectInputs.GetNumericInput("Geben Sie die Höhe ein:");
                            double resultAreaTrapezoid = Calculations.Trapezoid(lengthA, lengthC, height);
                            Console.WriteLine("Die Formel der Flächenberechnung eines Trapezes ist: ((Länge A + Länge C) / 2 * Höhe))");
                            Console.WriteLine($"Das Ergebnis von  (({lengthA} + {lengthC}) / 2 * {height})) = {resultAreaTrapezoid} in m²");
                            break;
                        case 8:

                            double lengthA1 = SelectInputs.GetNumericInput("Geben Sie die Länge a ein:");
                            double lengthB = SelectInputs.GetNumericInput("Geben Sie die Länge b ein:");
                            double lengthC1 = SelectInputs.GetNumericInput("Geben Sie die Länge c ein:");
                            double lengthD = SelectInputs.GetNumericInput("Geben Sie die Länge d ein:");
                            double resultScopeTrapezoid = Calculations.Trapezoid(lengthA1, lengthB, lengthC1, lengthD);
                            Console.WriteLine("Die Formel der Umfangberechnung eines Trapezes ist: Länge A + Länge B + Länge C + Länge D");
                            Console.WriteLine($"Das Ergebnis von  (({lengthA1} + {lengthB} + {lengthC1} + {lengthD} = {resultScopeTrapezoid} in m");
                            break;
                        case 9:
                            double radius = SelectInputs.GetNumericInput("Geben Sie den Radius ein:");
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



    