using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDPA_Vorprojekt_SAND
{
    public class Extras
    {
        public static void Tastatur(string Text)
        {
            /* Nimmt einen String und Schreibt jeden Buschstaben einer nach dem anderen,
             * um das schreiben einer Tastatur zu simulieren.
             */
            
            foreach (char c in Text)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine("");
        }
    }
}
