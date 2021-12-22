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
    class Feature11
    {
        internal static void FeatureMenue()
        {
            (int, int) cPosBM = Console.GetCursorPosition();

            Console.WriteLine();

            //ASCII art Logo wird erzeugt.
            Console.WriteLine
                (FiggleFonts.Slant.Render("FragBFT"));

            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                          >>> Bereich Binär zu Dezimal <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");
        redo:
            Console.WriteLine("Eingabe: hauptmenü\t->\tzurück zum Hauptmenü");
            Console.WriteLine("Eingabe: zu Dezimal\t->\tum von Binär zu Dezimal umzurechnen");
            string menueAuswahl = Console.ReadLine().ToLower();
            if (menueAuswahl == "zu dezimal")
            {
                Feature11Funcion1();
            }
            /*else if (menueAuswahl == "zu binär") //comming soon!
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
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static internal void Feature11Funcion1()
        {
            Console.WriteLine("Geben sie hiere Binärezahl ein");
            string input;
            input = Console.ReadLine();
            input = Reverse(input);
            double Summe = 0;
            //wenn input[0] eine '1'
            //dann addiere zur summe
            int I = 0;
            while (I < input.Length)
            {
                if ('1' == input[I])
                {
                    Summe = Summe + Math.Pow(2, I);
                }



                I++;
            }

            Console.WriteLine("Ihre Dezimal zahl ist {0}", Summe);
            Console.ReadLine();
            Console.Clear();
        }

    }
}