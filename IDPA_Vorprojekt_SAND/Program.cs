using System;
using IDPA_Vorprojekt_SAND;

namespace IDPA_Vorprojekt_SAND
{
    class Program
    {
        static void Main()
        {
            
        }

        static double Eingabe()
        {
            string input;
            double output = 0;
            while (output == 0)
            {
                try
                {
                    input = Console.ReadLine();
                    output = Convert.ToDouble(input);
                }
                catch
                {
                    Console.WriteLine("Es werden nur Zahlen aktzeptieren. Gib bitte eine gültige Eingabe ein.");
                }
            }
            return output;
        }
    }
}