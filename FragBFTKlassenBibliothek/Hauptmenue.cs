using System;
using Figgle;


namespace FragBFTKlassenBibliothek
{
    public class Hauptmenue
    {
        public static void HauptmenueAufruf()
        {


            do
            {

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("FragBFT12"));

                //Konsolentitel wird geändert.
                Console.Title = "FragBFT12";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Hauptmenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit der Software 'FragBFT12' sollen wiederkehrende oder besonders aufwendige\n" +
                                  "Aufgabenaus dem schulischen Kontext erleichtert oder gelöst werden. Diese Aufgaben\n" +
                                  "ergeben sich aus den Problemstellungen aus dem Unterricht der Berufsfachschule für Technik.\n\n");

                string HauptAusw;




                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\te - Elektrotechnik");
                Console.WriteLine("\ti - Informatik");
                Console.WriteLine("\tm - Mathematik");
                Console.WriteLine("\tp - Physik");
                Console.WriteLine("\tw - Wirtschaft\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "e":
                        Console.Clear();
                        ETFragBFTKlassenBibliothek.ETMenue.ETSubMenue();
                        break;

                    case "i":
                        Console.Clear();
                        ITFragBFTKlassenBibliothek.ITMenue.ITSubMenue();
                        break;

                    case "m":
                        Console.Clear();
                        MAFragBFTKlassenBibliothek.MAMenue.MASubMenue();
                        break;

                    case "p":
                        Console.Clear();
                        PYFragBFTKlassenBibliothek.PyMenue.PYSubMenue();
                        break;

                    case "w":
                        Console.Clear();
                        //WIMultiToolKlassenBibliothek.WIMenue.WISubMenue();
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

            } while (true);



        }
    }
}
