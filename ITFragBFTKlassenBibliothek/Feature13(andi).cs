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
    class Feature13
    {
        internal static void FeatureMenue()
        {
            (int, int) cPosBM = Console.GetCursorPosition();

            Console.WriteLine();

            //ASCII art Logo wird erzeugt.
            Console.WriteLine
                (FiggleFonts.Slant.Render("FragBFT"));

            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                          >>> Bereich Bits und Byte Rechner <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");
        redo:
            Console.WriteLine("Eingabe: hauptmenü\t->\tzurück zum Hauptmenü");
            Console.WriteLine("Eingabe: zu Byte\t->\tum von Bit zu Byte umzurechnen");
            Console.WriteLine("Eingabe: zu bit\t->\tum von Byte zu Bit umzurechnen");
            string menueAuswahl = Console.ReadLine().ToLower();
            if (menueAuswahl == "zu byte")
            {
                Feature13Funcion1();
            }
            else if (menueAuswahl == "zu bit") 
            {
                Feature13Funcion2();
            }
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
        static internal void Feature13Funcion1()
        {
            int bits = 0;
            int bytes = 0;
            Console.WriteLine("Wilkommen zum Bit und Byte Rechner");
            Console.WriteLine("Wenn Sie von Bit zu Byte rechnen dann drücken Sie die '1', falls von Byte zu Bit dann drücken Sie die '2'");
             string eingabe = Console.ReadLine();
            if(eingabe=="1" )
            {
                Console.WriteLine("Geben Sie Ihre Anzahl an Bits ein");
                string eingabebits = Console.ReadLine();
                int.TryParse(eingabebits, out bits);
                bytes = bits / 8;
                Console.WriteLine($"Es kommen {bytes} raus");
            }
            
        }
        static internal void Feature13Funcion2()
        {
          
        }
    }
}
