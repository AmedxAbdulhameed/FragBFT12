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
                                  "                              >>> Flächenberechnung Submenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit diesem Program können Sie Kreis,Parallelogramm,Rechteck und Dreieck Flächen berechnen\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Fläche:\n");
                Console.WriteLine("\t1 - Kreis ");
                Console.WriteLine("\t2 - Parallelogramm");
                Console.WriteLine("\t3 - Rechteck");
                Console.WriteLine("\t1 - Dreieck");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Kreis();
                        break;
                        

                    case "2":
                        Console.Clear();
                        Parallelogramm();
                        break;


                    case "3":
                        Console.Clear();
                        Rechteck();
                        break;

                    case "4":
                        Console.Clear();
                        Dreieck();
                        break;

                    case "submenü":
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





            static void Kreis()
            {

            }
            static void Parallelogramm()
            {

            }

            static void Rechteck()
            {

            }

            static void Dreieck()
            {

            }



        }
    }
}
