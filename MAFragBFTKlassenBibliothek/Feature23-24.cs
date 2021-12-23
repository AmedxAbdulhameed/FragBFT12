using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace MAFragBFTKlassenBibliothek
{
    class Feature23_24
    {
        internal static void Feature23_24Funcion2()
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
                                  "                              >>> Flächenberechnung Submenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Subptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit diesem Program können Sie Kreis,Parallelogramm,Rechteck und Dreieck Flächen berechnen\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Fläche:\n");
                Console.WriteLine("\t1 - Kreis ");
                Console.WriteLine("\t2 - Parallelogramm");
                Console.WriteLine("\t3 - Rechteck");
                Console.WriteLine("\t4 - Dreieck");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Kreis();
                        break;


                    case "2":
                        Console.Clear();
                        Parallelogramm();
                        break;


                    case "3":
                        Console.Clear();
                        Rechteck();
                        break;

                    case "4":
                        Console.Clear();
                        Dreieck();
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



        static void Kreis()
        {

            bool subexit = false;

            do
            {
                Console.WriteLine
                    (FiggleFonts.Slant.Render("^Frag Aras amca"));
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Kreisflächenberechnung<<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");


                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Subptmenü");
                Console.WriteLine("\nGeben Sie r ein");


                String r = Console.ReadLine();
                double d_r = 0;
                bool tryparse = true;

                if (r == "exit")
                {
                    Environment.Exit(0);
                }
                else if (r == "submenue")
                {
                    subexit = true;
                }
                else
                {




                    try
                    {
                        d_r = Convert.ToDouble(r);
                    }
                    catch (Exception e)
                    {

                        tryparse = false;
                    }


                    if (tryparse == true && d_r > 0)
                    {
                        Console.WriteLine("Die Fläche beträgt:{0,20:F2}m^2", d_r * Math.PI);
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("Fehleingabe");
                        Console.ReadKey();
                    }
                }
                Console.Clear();
            } while (subexit == false);
        }


        static void Rechteck()
        {

        }

        static void Dreieck()
        {

        }

        static void Parallelogramm()


        {

            bool subexit = false;
            double d_a = 0;
            double d_h = 0;

            do
            {
                Console.WriteLine
                   (FiggleFonts.Slant.Render("Frag Aras Amca"));
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Parallelogramflächenberechnung<<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("Flächenberechnung von Parallelogramm");
                Console.WriteLine("Geben Sie a ein");
               

                String a = Console.ReadLine();

                Console.WriteLine("Geben Sie h ein");
                String h = Console.ReadLine();

                bool tryparse = true;

                if (a == "exit")
                    
                    {
                        Environment.Exit(0);
                    }

                    else if (a == "submenue")
             
                    {
                        subexit = true;
                    }
                    else
                    {



                        try
                        {
                            d_a = Convert.ToDouble(a);
                            d_h = Convert.ToDouble(h);

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Fehleingabe");
                            tryparse = false;
                        }


                        if (tryparse == true && d_a > 0)
                        {
                            Console.WriteLine("Die Fläche beträgt:{0,20:F2}m^2", d_a * d_h);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Fehleingabe");
                            Console.ReadKey();
                        }

                        Console.Clear();



                    }






            } while (subexit == false);
        }
    }
}
