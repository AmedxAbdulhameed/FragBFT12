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
            Console.WriteLine("Eingabe: R\t->\tzum bits&byte rechner");
            string menueAuswahl = Console.ReadLine().ToLower();
            if (menueAuswahl == "r")
            {
                Feature13Funcion1();
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
            bool falscheEingabe = false; 
            do
            {
                Console.WriteLine("Wilkommen zum Bit und Byte Rechner");
                Console.WriteLine("Wenn Sie von Bit zu Byte rechnen dann drücken Sie die '1', falls von Byte zu Bit dann drücken Sie die '2'");
                string eingabe = Console.ReadLine();
                if (eingabe == "1")
                {
                    falscheEingabe = false;
                    Console.WriteLine("Geben Sie Ihre Anzahl an Bits ein");
                    string eingabebits = Console.ReadLine();
                    int.TryParse(eingabebits, out bits);
                    bytes = bits / 8;
                    Console.WriteLine($"Das Ergebnis ist {bytes} bytes");

                }
                else if (eingabe == "2")
                {
                    falscheEingabe = false;
                    Console.WriteLine("Geben Sie Ihre Anzahl an Bytes ein");
                    string eingabebytes = Console.ReadLine();
                    int.TryParse(eingabebytes, out bytes);
                    bits = bytes * 8;
                    Console.WriteLine($"Das Ergebnis ist {bits} bits");
                }
                else
                {
                    Console.WriteLine("falsche eingabe!");
                    falscheEingabe = true;
                    Console.ReadLine();
                }
            } while (falscheEingabe);
            Console.WriteLine("drücken sie eine taste");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
