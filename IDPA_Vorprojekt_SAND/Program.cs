using System;
using IDPA_Vorprojekt_SAND;
using static IDPA_Vorprojekt_SAND.Extras;

namespace IDPA_Vorprojekt_SAND
{
    class Program
    {
        static void Main()
        {
            double Kapital;
            double Geburtstag;
            double Zinssatz;
            double Bonus;
            while (true)
            {
                Tastatur("Geben Sie bitte dïe Höhe des Kapitals ein.");
                Console.WriteLine("Zum Beispiel: Falls Sie ein Kapital in Höhe von 203'495,55 haben dann geben Sie bitte 203495.55 ein.");
                Kapital = Eingabe();
                Tastatur("Geben Sie bitte den Tag an, an dem der Kunde Geburtstag hat");
                Console.WriteLine("Zum Beispiel: Falls Herr Müller am 21.06.2000 geboren ist ist nur 21 als Eingabe benötigt.");
                Geburtstag = Eingabe();
                Tastatur("Geben Sie den Spezialzinssatz an.");
                Console.WriteLine("Zum Beispiel: Falls Sie einen Zins von 2,1% eingeben wollen, dann geben Sie 2.1 ein.");
                Zinssatz = Eingabe();
                if (Geburtstag > 30)
                {
                    Geburtstag = 30;
                }
                else if(Geburtstag < 1)
                {
                    Geburtstag = 1;
                }
                Bonus = Kapital * Zinssatz / 100 / 360 * Geburtstag;
                Tastatur("Der Bonus für den Kunden beträgt " + Bonus + " CHF.");
                Tastatur("Wollen Sie noch einen Kunden erfassen? [Ja/Nein]");
                if(Console.ReadLine() == "Nein")
                {
                    Environment.Exit(0);
                }

            }
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
                    Tastatur("Es werden nur Zahlen aktzeptieren. Gib bitte eine gültige Eingabe ein.");
                }
            }
            return output;
        }
    }
}