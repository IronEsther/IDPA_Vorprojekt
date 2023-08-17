using System;
using IDPA_Vorprojekt_SAND;

namespace IDPA_Vorprojekt_SAND
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Marchzins-Bonus Rechner");

            Console.Write("Geben Sie den Monat (1-12) ein: ");
            int monat = GetIntegerInput(1, 12);

            Console.Write("Basiszinssatz (%) eingeben: ");
            double basisMarchzinsRate = verifiziereEingabe();

            Console.Write("Möchten Sie den speziellen Zins berechnen? (ja/nein): ");
            string entscheidung = Console.ReadLine();

            GeburtstagMarchZinsRechner rechner = new GeburtstagMarchZinsRechner();

            if (entscheidung.ToLower() == "ja")
            {
                Console.Write("Geben Sie den individuellen Zinssatz (%) ein: ");
                double individualInterestRate = verifiziereEingabe();

                Console.Write("Geben Sie den Tag des Geburtstags ein: ");
                int geburtstag = GetIntegerInput(1, 31);

                rechner.GeburtstagsbonusRate(monat,basisMarchzinsRate, individualInterestRate, geburtstag);
            }
            else
            {
                rechner.BonusGenerieren(monat, basisMarchzinsRate);
            }
        }

        static int GetIntegerInput(int minWert, int maxWert)
        {
            int wert;
            while (!int.TryParse(Console.ReadLine(), out wert) || wert < minWert || wert > maxWert)
            {
                Console.Write($"Ungültige Eingabe. Bitte geben Sie eine Zahl zwischen {minWert} und {maxWert} ein: ");
            }
            return wert;
        }

        static double verifiziereEingabe()
        {
            double wert;
            while (!double.TryParse(Console.ReadLine(), out wert) || wert < 0)
            {
                Console.Write("Ungültige Eingabe. Bitte geben Sie eine positive Zahl ein: ");
            }
            return wert;
        }
    }
}