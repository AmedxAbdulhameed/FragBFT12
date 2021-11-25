using System;
using Figgle;


namespace ITFragBFTKlassenBibliothek
{
    public class ITMenue
    {
        public static void ITSubMenue()
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
                Console.WriteLine("\n\nHier können Sachen die für Informatiker relevat sind berechnet werden\n\n"); // mach ich später xD

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Binär zu Dezimal");
                Console.WriteLine("\t2 - Nullstellen-Rechner");
                Console.WriteLine("\t3 - Bits und Byte Rechner");
                Console.WriteLine("\t4 - Vektoren-Rechner\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Feature11.FeatureMenue();
                        break;

                    case "2":
                        Console.Clear();
                        Feature12.FeatureMenue();
                        break;

                    case "3":
                        Console.Clear();
                        Feature13.FeatureMenue();
                        break;

                    case "4":
                        Console.Clear();
                        Feature14.FeatureMenue();
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
