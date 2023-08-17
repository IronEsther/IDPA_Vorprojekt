using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDPA_Vorprojekt_SAND
{
    class GeburtstagMarchZinsRechner
    {   
        public double BonusGenerieren(int monat, double basisZinsRate)
        {
            double bonus = ((basisZinsRate / 100) * 30);

            Console.WriteLine($"Zusätzlicher Zinsbetrag für den Monat {monat} : {bonus:C}");

            return bonus;
        }

        public double GeburtstagsbonusRate(int monat, double basisZinsRate, double IndividuelleMarchZinsrate, int geburtstag)
        {
            double bonus = 0;
            int tageImMonat = 30;

            if (tageImMonat > geburtstag || geburtstag == 31)
            {
                if (geburtstag == 31)
                {
                    geburtstag = 30;
                }

                bonus = (((basisZinsRate /100) / 30) * (geburtstag)) + ((IndividuelleMarchZinsrate / 100) * (geburtstag));

                Console.WriteLine($"Zusätzlicher Zinsbetrag für den Monat {monat} : {bonus:C}");
            }
            else
            {
                Console.WriteLine("Der individuelle Zinssatz ist nur bis zum Geburtstag gültig.");
            }

            return bonus;
        }
    }

}
