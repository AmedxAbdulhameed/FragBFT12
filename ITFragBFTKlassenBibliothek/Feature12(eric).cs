using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace ITFragBFTKlassenBibliothek
{
 /*
 WICHTIG!!! 

 Bitte erstelle eine neue Branch basierend auf ITEntwickellung und bearbeite da diese datei. 
 Bitte keine Änderungen an anderen dateien vornehmen.
 Wenn du möchtest das ich (Angelo) das menü für dein Feature erstelle, dann lass es mich wissen.
 Wenn du mir nichts Mitteilst gehe ich davon aus das du das Menü selber erstellst.
 Der Einstiegspunkt für deine Klasse ist die FeatureMenue Methode.
 */
    class Feature12
    {
        internal static void FeatureMenue()
        {
            (int, int) cPosBM = Console.GetCursorPosition();

            Console.WriteLine();

            //ASCII art Logo wird erzeugt.
            Console.WriteLine
                (FiggleFonts.Slant.Render("FragBFT"));

            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                          >>> Bereich Nullstellen berechnen <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");
        redo:
            Console.WriteLine("Eingabe: hauptmenü\t->\tzurück zum Hauptmenü");
            Console.WriteLine("Eingabe: PQ\t->\tum nullstellen mit der p/q formel zu umzurechnen");
            string menueAuswahl = Console.ReadLine().ToLower();
            if (menueAuswahl == "pq")
            {
                Feature12Funcion1();
            }
            /*else if (menueAuswahl == "something else") //comming soon!
              {
                  Feature11Funcion2();
              }*/
            else if (menueAuswahl == "hauptmenü")
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("falsche eingabe!\n\n");
                goto redo;
            }
        }

        internal static double[] nullstellenFinden(double p, double q)
        {
            double minusPHalbe = (p * (-1))/2;
            double pHalbeQuadrat = (p / 2) * (p / 2);
            double minusQ = q * (-1);
            double pHalbeQuadratMinusQ = pHalbeQuadrat - minusQ;

            double wurzel = Math.Sqrt(pHalbeQuadratMinusQ);
            if (wurzel == double.NaN)
            {
                return new [] {double.NaN, double.NaN};
            }
            //da fehlt noch was


        }
        internal static void Feature12Funcion1()
        {
            Console.WriteLine("eingabe von q");
            Console.ReadLine();
            String eingabeVonQ=Console.ReadLine();
            Console.WriteLine("eingabe von p");
            Console.ReadLine();
            String eingabeVonP = Console.ReadLine();
            double eingabeQ;
            double.TryParse(eingabeVonQ,out eingabeQ);
            double eingabeP;
            double.TryParse(eingabeVonP, out eingabeP);
            double[] Nulstellen = nulstellenFinden(eingabeVonP, eingabeVonQ);





            Console.WriteLine("Feature");
        }
    }
}
