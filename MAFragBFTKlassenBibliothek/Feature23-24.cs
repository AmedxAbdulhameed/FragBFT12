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
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Hauptmenü");

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

        }
        static void Parallelogramm()
        {

        }

        #region Rechteck
        static void Rechteck()
        {

            



            bool subexit = false;

            double d_a = 0;

            double d_b = 0;



            do
            {

                Console.WriteLine

                    (FiggleFonts.Slant.Render("Frag Amed Abe"));

                Console.WriteLine("------------------------------------------------------------------------------------\n" +

                                    "                              >>> Rechteckflächenberechnung<<<\n" +

                                    "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenue\t->\tzurück zum Submenü");

                Console.WriteLine("\nFlächenberechnung von Parallelogramm");

                Console.WriteLine("Geben Sie a ein");





                String a = Console.ReadLine();







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
                    }

                    catch (Exception e)
                    {       
                        Console.WriteLine("Fehleingabe");

                        tryparse = false;

                    }





                    if (tryparse == false && d_a < 0)

                    {

                        Console.WriteLine("Fehleingabe");

                        Console.ReadKey();

                    }

                }



                if(subexit==false)
                {
                    Console.WriteLine("Geben Sie b ein");
                    String b = Console.ReadLine();

                    if (b == "exit")
                    {
                        Environment.Exit(0);
                    }
                    else if (b == "submenue")
                    {
                        subexit = true;
                    }
                    else
                    {



                        try

                        {
                            d_b = Convert.ToDouble(b);
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine("Fehleingabe");

                            tryparse = false;

                        }





                        if (tryparse == false && d_b < 0)

                        {

                            Console.WriteLine("Fehleingabe");

                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine("Der Flächeninhalt hat den Wert {0}[m^2]",(d_a*d_b));
                            Console.ReadKey();
                        }

                    }


                }




                Console.Clear();
            } while (subexit == false);

        }

        #endregion

        static void Dreieck()
        {




            bool subexit = false;

            double d_g = 0;

            double d_h = 0;



            do
            {

                Console.WriteLine

                    (FiggleFonts.Slant.Render("Frag Amed Abe"));

                Console.WriteLine("------------------------------------------------------------------------------------\n" +

                                    "                              >>> Dreieckflächenberechnung<<<\n" +

                                    "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenue\t->\tzurück zum Submenü");

                Console.WriteLine("\nFlächenberechnung von Parallelogramm");

                Console.WriteLine("Geben Sie g ein");





                String g = Console.ReadLine();







                bool tryparse = true;



                if (g == "exit")



                {

                    Environment.Exit(0);

                }
                else if (g == "submenue")



                {

                    subexit = true;

                }

                else

                {



                    try

                    {
                        d_g = Convert.ToDouble(g);
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("Fehleingabe");

                        tryparse = false;

                    }





                    if (tryparse == false && d_g < 0)

                    {

                        Console.WriteLine("Fehleingabe");

                        Console.ReadKey();

                    }

                }



                if (subexit == false)
                {
                    Console.WriteLine("Geben Sie h ein");
                    String h = Console.ReadLine();

                    if (h == "exit")
                    {
                        Environment.Exit(0);
                    }
                    else if (h == "submenue")
                    {
                        subexit = true;
                    }
                    else
                    {



                        try

                        {
                            d_h = Convert.ToDouble(h);
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine("Fehleingabe");

                            tryparse = false;

                        }





                        if (tryparse == false && d_h < 0)

                        {

                            Console.WriteLine("Fehleingabe");

                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine("Der Flächeninhalt hat den Wert {0}[m^2]", (d_g * d_h));
                            Console.ReadKey();
                        }

                    }


                }




                Console.Clear();
            } while (subexit == false);


        }


        

    }    
}
    
