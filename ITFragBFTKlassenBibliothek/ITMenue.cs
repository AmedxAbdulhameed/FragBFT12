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
                Console.WriteLine("\n\nBeschreibung Bereich \n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Feature15");
                Console.WriteLine("\t2 - Feature16");
                Console.WriteLine("\t3 - Feature17");
                Console.WriteLine("\t4 - Feature18\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        
                        /*
                            call static klasse feature 1...
                            do something with the class 
                            code: 
                            Console.WriteLine("aufforderung etwas einzugeben");
                            string input = Console.ReadLine();
                            feature1();
                            feature.something();
                            Console.WriteLine(feature.somethingElse);
                            
                         */
                        
                        break;

                    case "2":
                        Console.Clear();

                        break;

                    case "3":
                        Console.Clear();

                        break;

                    case "4":
                        Console.Clear();

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
