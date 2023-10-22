using System;
namespace KMS_01_06_LE_02_05
{
    public class SelectInputs
    {
        public static double GetNumericInput(string input)
        {
            double value = 0;
            bool checkInput = false;

            while (!checkInput)

            {
                try
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
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
            return value;
        }
    }     
}
    
