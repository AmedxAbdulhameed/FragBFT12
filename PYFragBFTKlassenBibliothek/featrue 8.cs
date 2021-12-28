using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYFragBFTKlassenBibliothek
{
    class Feature8
    {
        internal static void Feature8Funcion1()
        {
            Console.WriteLine("Feature8");
            double m = 0, g = 0, G = 0, neustart = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("<<<<<<<<<<<<<<<-Gewichtskraft->>>>>>>>>>>>>>>");
                Console.WriteLine("Geben sie den wert für Masse des Körpers an");
                m = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Geben sie den wert für Beschleunigung des Körpers an");
                g = Convert.ToDouble(Console.ReadLine());
                G = m * g;
                Console.WriteLine("ihre Gewichtskraft beträgt:");
                Console.Write(G);
                Console.WriteLine("Soll das Feature neugestartet werden? Wenn ja 1 wenn nein 2");
                neustart = Convert.ToDouble(Console.ReadLine());
            } while (neustart == 1);
        }
    }
}