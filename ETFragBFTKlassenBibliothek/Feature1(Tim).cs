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


            {
                

                Console.WriteLine
                (FiggleFonts.Slant.Render("BFTMultiTool"));


                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Leistungsrechner <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                
                Console.WriteLine("Mein Leistungsrechner");
                Console.WriteLine("---------------------\n");
                Console.WriteLine("\t1 - Elektrische Spannung * Elektrischen Strom");
                Console.WriteLine("\t2 - Leistung / Elektrische Spannung");
                Console.WriteLine("\t3 - Elektrischen Strom / Leistung\n");                           
                Console.WriteLine("Wählen sie eine rechnung aus");
                string rechnung = Console.ReadLine();
                



                if (rechnung == "1")
                {
                    Console.WriteLine("Geben sie hier eine Zahl U für die elektrische spannung ein");
                    Double zahl1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Geben sie Hier eine Zweite Zahl I für den elektrischen strom ein");
                    Double zahl2 = Convert.ToDouble(Console.ReadLine());
                    Double ergebnis = 0;


                    ergebnis = zahl1 * zahl2;

                    Console.WriteLine($"das ergebnis P für Leistung ist: {ergebnis}");
                    Console.Read();
                    Console.Clear();
                }
                else if (rechnung == "2")
                {
                    Console.WriteLine("Geben sie hier eine Zahl P für die Leistung ein");
                    Double zahl1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Geben sie Hier eine Zweite Zahl U für den elektrische Spannung ein");
                    Double zahl2 = Convert.ToDouble(Console.ReadLine());
                    Double ergebnis = 0;


                    ergebnis = zahl1 / zahl2;

                    Console.WriteLine($"das ergebnis I für den Elektrischen Strom ist: {ergebnis}");
                    Console.Read();
                    Console.Clear();

                }
                else if (rechnung == "3")
                {
                    Console.WriteLine("Geben sie hier eine Zahl I für die elektrischen Strom ein");
                    Double zahl1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Geben sie Hier eine Zweite Zahl P für die Leistung ein");
                    Double zahl2 = Convert.ToDouble(Console.ReadLine());
                    Double ergebnis = 0;


                    ergebnis = zahl1 / zahl2;

                    Console.WriteLine($"das ergebnis U für die Elektrische Spannung ist: {ergebnis}");
                    Console.Read();
                    Console.Clear();
                }
               
               


                Console.Clear();

                


            }




        }
    }
}
