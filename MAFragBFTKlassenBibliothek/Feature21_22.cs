using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace MAFragBFTKlassenBibliothek
{
    class Feature21_22
    {
        internal static void Feature21_22Funcion1()
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
                                  "                              >>> Lineare Funktionen Submenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit diesem Program können Sie Lineare Funktionen berechnen\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Wertetabell");
                Console.WriteLine("\t2 - Nullstellen");
                Console.WriteLine("\t3 - Funktion Ausgeben");


                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Wertetabelle();

                        break;

                    case "2":
                        Console.Clear();
                        Nullstellen();

                        break;

                    case "3":
                        Console.Clear();
                        Funktion_Ausgeben();


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


        static void Wertetabelle()
        {
            double c = 0; // 0
            double d; //B
            double f; // B
            double e;
            double g;


            Console.WriteLine("Nullstelle Berechnen\n");
            Console.WriteLine("Geben sie m ein");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben sie b ein");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}x + {1} = {2} ", m, b, c);



            d = b - b;



            f = c - b;

            Console.WriteLine("{0}x = {1} ", m, f);

            e = f / m;



            g = m / m;

            Console.WriteLine("{0}x = {1} ", g, e);





            double sweite = 1;
            double von = -10;
            double bis = 10;



            Console.WriteLine("|{0,10}|{1,10}|", "x", "y");
            Console.WriteLine("----------------------|");


            for (double l_x = von; l_x <= bis; l_x += sweite)
            {
                Console.WriteLine("|{0,10:F2}|{1,10:F2}|", l_x, (l_x * m + b));
            }
            Console.ReadKey();
            Console.Clear();
        }

        static void Nullstellen()
        {
            double c = 0; // 0
            double d; //B
            double f; // B
            double e;
            double g;


            Console.WriteLine("Nullstelle Berechnen\n");          
            Console.WriteLine("Geben sie m ein");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben sie b ein");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}x + {1} = {2} ", m, b, c);



            d = b - b;

            Console.WriteLine("{0}x + {1} = {2} ", m, d, c);

            f = c - b;

            Console.WriteLine("{0}x = {1} ", m, f);

            e = f / m;

            Console.WriteLine("{0}x {1} ", m, e);

            g = m / m;

            Console.WriteLine("{0}x = {1} ", g, e);

        }
        static void Funktion_Ausgeben()
        {
            Console.WriteLine("Funktionsgleichung Ausgeben\n");      
            Console.WriteLine("Geben sie m ein");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben sie b ein");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("f(x)={0}x+{1}", m, b);


        }
    }
}
