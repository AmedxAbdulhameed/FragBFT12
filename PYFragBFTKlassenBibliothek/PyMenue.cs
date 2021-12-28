using System;
using Figgle;

namespace PYFragBFTKlassenBibliothek
{
    public class PyMenue
    {

        public static void PYSubMenue()
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
                                  "                              >>> Bereich Pyhsik <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tzurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\n Hierkönnen sie bestimmte Themen von Pyhsik erarbeiten \n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Werte umrechnen ");
                Console.WriteLine("\t2 - Volumen Berechnung von Gemotrischen Körper");
                Console.WriteLine("\t3 - Gewichtskraft ");
                Console.WriteLine("\t4 - Geschwindigkeiten  \n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Class1.Feature6Funcion1();

                        break;

                    case "2":
                        Console.Clear();
                        Class2.Feature9Funcion1();
                        break;

                    case "3":
                        Console.Clear();
                        Feature8.Feature8Funcion1();
                        break;

                    case "4":
                        Console.Clear();

                        Feature7.Feature7Funcion1();

                        

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
