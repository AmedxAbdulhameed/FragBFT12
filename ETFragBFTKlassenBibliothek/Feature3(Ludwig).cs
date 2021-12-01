using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFragBFTKlassenBibliothek
{
    public class Feature3
    {
        public static void Feature3Funcion3()
        {
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Berechnung von Wiederstand <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
            string Ausw1;
            Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
            Console.WriteLine("\t1 - Wiederstand");
            Console.WriteLine("\t2 - Spannung");
            Console.WriteLine("\t3 - Stromstärke");
            Console.WriteLine("\t4 - Spannungsfall\n");
            Console.Write("Eingabe:");
            Ausw1 = Console.ReadLine();

            switch (Ausw1)
            {

                case "1":
                    Console.Clear();

                    break;

                case "2":
                    Console.Clear();
                    Feature2.Feature2Funcion2();

                    break;

                case "3":
                    Console.Clear();
                    Feature3.Feature3Funcion3();

                    break;

                case "4":
                    Console.Clear();
                    Feature4.Feature4Funcion4();

                    break;











            }

        }
    }
}
