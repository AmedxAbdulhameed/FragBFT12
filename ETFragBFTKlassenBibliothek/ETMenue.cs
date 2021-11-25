using System;
using Figgle;

namespace ETFragBFTKlassenBibliothek
{
    public class ETMenue
    {

        public static void ETSubMenue()
        {


            string HauptAusw;

 
            bool Hmenue;

            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Elektrotechnik Submenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tzurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit diesem Programm können sie Verschiede Bereiche der Elektrotechnik Berechnen\n");
                Console.WriteLine("- Elektrotechnische Grundlagen");
                Console.WriteLine("- Berechnung der Bauelemente(Eingabe oder Auswahl der Parameter)");
                Console.WriteLine("- Leitungsberechnung\n");
              
                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Bruttorechner");
                Console.WriteLine("\t2 - Ohmisches Gesetz");
                Console.WriteLine("\t3 - Berechnung von Wiederstand");
                Console.WriteLine("\t4 - Spannungsfall\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Feature1.Feature1Funcion1();
                        
                        break;

                    case "2":
                        Console.Clear();
                        Feature2.Feature2Funcion2();

                        break;

                    case "3":
                        Console.Clear();
                        Feature3.Feature3Funcion3();

                        break;

                    case "4":
                        Console.Clear();
                        Feature4.Feature4Funcion4();

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


            } while ( !Hmenue);
        }
    }
}
