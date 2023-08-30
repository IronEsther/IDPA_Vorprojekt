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
            foreach (char c in Text)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine("");
        }
    }
}
