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

            Console.WriteLine("Wertetabelle Ausgabe\n");
            Console.WriteLine("Geben sie m ein");
            double m = Convert.ToDouble(Console.ReadLine());
                

            Console.WriteLine("Geben sie b ein");
            double b = Convert.ToDouble(Console.ReadLine());


            string X = "x";
            string Y = "y";

            Console.WriteLine("|{ 0,10},{ 1,10}|", X, Y);
            for (int x_z = -5; x_z <= 5; x_z++)

            {
                Console.WriteLine("|{ 0,10}|{ 1,10}|", x_z, m * x_z + b);

            }

            Console.ReadKey();




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


            f = c - b;

            Console.WriteLine("{0}x = {1} ", m, f);

            e = f / m;


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
