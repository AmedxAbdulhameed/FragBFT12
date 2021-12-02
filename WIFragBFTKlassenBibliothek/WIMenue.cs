using System;
using Figgle;

namespace WIFragBFTKlassenBibliothek
{
    public class WIMenue
    {
        public static void WISubMenue()
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
                                  "                              >>> Wirtschaft Submenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tzurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nIm Wirt \n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Feature15");
                Console.WriteLine("\t2 - Lohnsteuerrechner");
                Console.WriteLine("\t3 - Selbständigrechner");
                Console.WriteLine("\t4 - Zinsrechner");
                Console.WriteLine("\t5 - Inmobilienrechner\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Feature15.Feature15Funcion1();

                        break;

                    case "2":
                        Console.Clear();
                        Feature16.Feature16Funcion1();
                        break;

                    case "3":
                        Console.Clear();
                        Feature17.Feature17Funcion1();
                        break;

                    case "4":
                        Console.Clear();
                        Feature18.Feature18Funcion1();
                        break;

                    case "5":

                        Console.Clear();
                        Feature19.Feature19Funcion1();
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
