using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;
namespace ETFragBFTKlassenBibliothek
{
    public class Feature1
    {
        public static void Feature1Funcion1()

        {
           
        
            string HauptAusw;


            bool Hmenue;

            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();
                //Test Chaufan
                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Leistungsrechner Submenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Submenü");



                Hmenue = false;

                Console.WriteLine("Mein Leistungsrechner");
                Console.WriteLine("---------------------\n");
                Console.WriteLine("\t1 - Elektrische Spannung * Elektrischen Strom");
                Console.WriteLine("\t2 - Leistung / Elektrische Spannung");
                Console.WriteLine("\t3 - Elektrischen Strom / Leistung\n");
                Console.WriteLine("Wählen sie eine rechnung aus");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        SpannungStrom();

                        break;

                    case "2":
                        Console.Clear();
                        LeistungSpannung();

                        break;

                    case "3":
                        Console.Clear();
                        StromLeistung();

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
        }


        #region Funktion1(SpannungStrom)
        static void SpannungStrom()
        {
            try
            {

                Console.WriteLine("Geben sie hier eine Zahl U für die elektrische spannung ein");
                Double zahl1 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Geben sie Hier eine Zweite Zahl I für den elektrischen strom ein");
                Double zahl2 = Convert.ToDouble(Console.ReadLine());
                Double ergebnis = 0;


                ergebnis = zahl1 * zahl2;


                Console.WriteLine($"das ergebnis P für Leistung ist: {ergebnis}W");
                Console.Read();
                Console.Clear();

            }
            catch
            {
                Console.WriteLine("flasche eingabe");
                Console.ReadKey();
                Console.Clear();

            }
        }
        #endregion

        #region Funktion2(LeistungSpannung)
        static void LeistungSpannung()
        {
            try
            {

                Console.WriteLine("Geben sie hier eine Zahl P für die Leistung ein");
                Double zahl1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Geben sie Hier eine Zweite Zahl U für die elektrische Spannung ein");
                Double zahl2 = Convert.ToDouble(Console.ReadLine());
                Double ergebnis = 0;

                ergebnis = zahl1 / zahl2;

                Console.WriteLine($"das ergebnis I für den Elektrischen Strom ist: {ergebnis}A");
                Console.Read();
                Console.Clear();
            }
            catch
            {
                Console.WriteLine("flasche eingabe");
                Console.ReadKey();
                Console.Clear();
            }
        }

        #endregion

        #region Funktion3(StromLeistung)
        static void StromLeistung()
        {
            try
            {
                
                Console.WriteLine("Geben sie hier eine Zahl I für den elektrischen Strom ein");
                Double zahl1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Geben sie Hier eine Zweite Zahl P für die Leistung ein");
                Double zahl2 = Convert.ToDouble(Console.ReadLine());
                Double ergebnis = 0;


                ergebnis = zahl1 / zahl2;

                Console.WriteLine($"das ergebnis U für die Elektrische Spannung ist: {ergebnis}V");
                Console.Read();
                Console.Clear();
            }
            catch
            {
                Console.WriteLine("flasche eingabe");
                Console.ReadKey();
                Console.Clear();

            }


        }



        #endregion


        }
}
