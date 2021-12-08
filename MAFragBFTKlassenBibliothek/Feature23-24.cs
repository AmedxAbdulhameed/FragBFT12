using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace MAFragBFTKlassenBibliothek
{
    class Feature23_24
    {
        internal static void Feature23_24Funcion2()
        {


            string HauptAusw;


            bool Hmenue;

            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("FragBFT"));

                //Konsolentitel wird geändert.
                Console.Title = "FragBFT";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Bereich Submenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tzurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit diesem Program können Sie Flächen,Lineare und Quadratische Funktionen berechnen\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Quadratische Funnktionen");
                Console.WriteLine("\t2 - Lineare Funktionen");
                Console.WriteLine("\t3 - Flächenberechnung");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Feature20.Feature20Funcion1();

                        break;

                    case "2":
                        Console.Clear();
                        Feature21_22.Feature21_22Funcion1();
                        break;

                    case "3":
                        Console.Clear();
                        Feature23_24.Feature23_24Funcion2();
                        break;


                    case "hauptmenü":
                        Console.Clear();
                        Hmenue = true;
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;

                    default:

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();


                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }


            } while (!Hmenue);
        }
    }
}
