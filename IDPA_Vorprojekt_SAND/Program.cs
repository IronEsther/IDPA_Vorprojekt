using System;
using IDPA_Vorprojekt_SAND;
using static IDPA_Vorprojekt_SAND.Extras;

namespace IDPA_Vorprojekt_SAND
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Abfrage();
                ZinsertragFormel();
                WeitererKunde();
            }
        }

        public static void Abfrage()
        {
            //Fragt den Nutzer nach bestimmten Eingaben ab, um die nötigen Werte für die Zinsertragberechnung zu erhalten.

            Tastatur("Geben Sie bitte die Höhe des Kapitals ein.");
            Console.WriteLine("Zum Beispiel: Falls Sie ein Kapital in Höhe von 203'495,55 haben dann geben Sie bitte 203495.55 ein.");
            Kapital = Eingabe(1);
            Tastatur("Geben Sie bitte den Tag an, an dem der Kunde Geburtstag hat");
            Console.WriteLine("Zum Beispiel: Falls Herr Müller am 21.06.2000 geboren ist ist nur 21 als Eingabe benötigt.");
            Geburtstag = Eingabe(2);
            Tastatur("Geben Sie den Spezialzinssatz an.");
            Console.WriteLine("Zum Beispiel: Falls Sie einen Zins von 2,1% eingeben wollen, dann geben Sie 2.1 ein.");
            Zinssatz = Eingabe(1);
        }

        static double Eingabe(int Funktion)
        {
            /* Funktion um die Eingabe eines Nutzers zu behandeln, gibt einen Double zurück.
             * Nimmt ausserdem Integer um spezielle Szenarien spezifisch zu behandeln.
             */

            string input;
            double output = 0;

            ErsterFehler = true;
            //Setzt ErsterFehler auf "true" um bei der ersten Falscheingabe einen Kommentar in der Konsole auszugeben.

            while (true)
            {
                try
                {
                    input = Console.ReadLine();
                    output = Convert.ToDouble(input);

                    if (Funktion == 2)
                    {
                        //Wird ausgeführt um beim Geburtsdatum Fehleingaben speziell zu behandeln.

                        if (output == 31)
                        {
                            output = 30;
                        }
                        else if (output > 31 || output < 1)
                        {
                            throw new Exception();
                        }
                    }

                    if (output < 0)
                    {
                        throw new Exception();
                    }

                    break;
                }
                catch
                {
                    FehlerBehandlung();
                    //Wird ausgeführt, wenn der Nutzer eine falsche Eingabe tätigt.
                }
            }
            return output;
        }

        //Variabeln für die Zinsberechnung.
        public static double Kapital;
        public static double Geburtstag;
        public static double Zinssatz;
        public static double Bonus;

        public static void ZinsertragFormel()
        {
            //Berechnet die zu erhaltenden Zinsen für den Kunden.

            Bonus = Kapital * Zinssatz / 100 / 360 * Geburtstag;
            Tastatur("Der Bonus für den Kunden beträgt " + Bonus + " CHF.");
        }

        public static void WeitererKunde()
        {
            // Fragt Nutzer ob noch ein weiterer Kunde berechnet werden soll. Wenn nein, wird das Programm beendet.

            Tastatur("Wollen Sie noch einen Kunden erfassen? [Ja/Nein]");
            if (Console.ReadLine().ToLower() == "nein")
            {
                Environment.Exit(0);
            }
        }



        public static bool ErsterFehler = true;
        // Boolean für die Fehlerbehandlung. Wird auf "false" verändert um das hinzufügen eines Kommentars in der Konsole zu verhindern.

        public static void FehlerBehandlung()
        {
            /* Fehlerbehandlung für Eingabe.
             * Der Code ändert die letzte Zeile in der Konsole um die Konsolenausgabe besser aussehen zu lassen.
             * Quelle: https://stackoverflow.com/a/8946847
             */

            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);

            if(ErsterFehler == true)
            {
                //Fehlergrund wird nur bei der ersten Fehleingabe ausgegeben.

                Tastatur("Es werden nur Zahlen aktzeptieren. Geben Sie bitte eine gültige Eingabe ein.");
                ErsterFehler = false;
            }
        }
    }
}
