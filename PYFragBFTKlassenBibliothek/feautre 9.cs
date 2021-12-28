using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace PYFragBFTKlassenBibliothek
{
    class Class2
    {
      internal static void Feature9Funcion1()
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
                                  "                              >>> Volumen von Körper berechen <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Hauptmenü");



                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Pyramide");
                Console.WriteLine("\t2 - Kugel");
                Console.WriteLine("\t3 - Wuerfel ");
                
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Pyramide();

                        break;

                    case "2":
                        Console.Clear();
                        Kugel();
                        break;

                    case "3":
                        Console.Clear();
                        Wuerfel();
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


        static void Pyramide()
        {
            Console.WriteLine("Geben Sie die Grundfläche der Pyramide in [m^2] an");
            double g = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben Sie die Höhe der Pyramide in [m] an");
            double h = Convert.ToDouble(Console.ReadLine());

            double v =g*h;


            Console.WriteLine("Das Volumen der Pyramide beträgt:{0,10} [m^3]", v);

            Console.ReadKey();
            Console.Clear();
        }

        static void Kugel()
        {
            Console.WriteLine("Geben Sie den Radius der Kugel in [m] an");
            double r = Convert.ToDouble(Console.ReadLine());

            double v = Math.PI * Math.Pow(r,3);

            Console.WriteLine("Das Volumen der Kugel beträgt:{0,10} [m^3]", v);
            Console.ReadKey();
            Console.Clear();

        }

        static void Wuerfel()
        {
            Console.WriteLine("Geben Sie den Radius des Würfels in [m] an");
            double r = Convert.ToDouble(Console.ReadLine());

            double v = r*r*r;

            Console.WriteLine("Das Volumen des Würfels beträgt:{0,10} [m^3]", v);
            Console.ReadKey();
            Console.Clear();


        }



    }
}
