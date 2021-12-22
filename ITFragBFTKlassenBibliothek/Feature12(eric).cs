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

        internal static double?[] nullstellenFinden(double p, double q) // funktion von angelo
        {
            double minusPHalbe = (p * (-1))/2;
            double pHalbeQuadrat = (p / 2) * (p / 2);
            double pHalbeQuadratMinusQ = pHalbeQuadrat - q;

            double wurzel = Math.Sqrt(pHalbeQuadratMinusQ);
            //Console.WriteLine(wurzel); fürs debuging
            if (double.IsNaN(Math.Sqrt(pHalbeQuadratMinusQ)))
            {
                //Console.WriteLine("klappt"); für debuging 
                return new double?[] {null, null}; 
            }
            double x1 = minusPHalbe - wurzel;
            double x2 = minusPHalbe + wurzel;
            return new double?[] { x1, x2 };
        }
        internal static void Feature12Funcion1()
        { 
            bool Wiederholen = false;
            do
            {
               
                Console.WriteLine("eingabe von q");
                
                String eingabeVonQ = Console.ReadLine();
                Console.WriteLine("eingabe von p");
             
                String eingabeVonP = Console.ReadLine();
                double eingabeQ;
                double.TryParse(eingabeVonQ, out eingabeQ);
                double eingabeP;
                double.TryParse(eingabeVonP, out eingabeP);
                double?[] Nullstellen = nullstellenFinden(eingabeP, eingabeQ);



                //Console.WriteLine(Nullstellen[0]);
                //Console.WriteLine(Nullstellen[1]);
                //Console.WriteLine("Kein Ergebniss");
                if (Nullstellen[0] == null && Nullstellen[1]== null)
                {
                    Console.WriteLine("kein Ergebnis");
                    Console.WriteLine("drücken sie eine Taste");
                    Console.ReadLine();
                    Wiederholen = true;
                }
                else //if (Nullstellen[0] >= double.MaxValue && Nullstellen[1] >= double.MaxValue)
                {
                    Console.WriteLine("Ergebnis: {0} , {1}",Nullstellen[0],Nullstellen[1]);
                    Console.WriteLine("drücken sie eine Taste");
                    Console.ReadLine();
                    Wiederholen = false;
                }
                Console.ReadLine();
                Console.Clear();


            } while (Wiederholen);

            //Console.WriteLine("Feature");
        }
    }
}
