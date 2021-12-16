using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;
namespace ETFragBFTKlassenBibliothek
{
    public class Feature2
    {
        public static void Feature2Funcion2()

        {

            {
                while (true)
                {

                    Console.WriteLine
                (FiggleFonts.Slant.Render("BFTMultiTool"));


                    Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                      "                              >>> Ohmsches Gesetz <<<\n" +
                                      "------------------------------------------------------------------------------------\n\n");

                    Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                    Console.WriteLine("Eingabe: submenü\t->\tzurück zum submenü\n");

                    Console.WriteLine("Ohmsches Gesetz");
                    Console.WriteLine("---------------------\n");
                    Console.WriteLine("\t1 - Widerstand berechnen");
                    Console.WriteLine("\t2 - Spannung berechnen");
                    Console.WriteLine("\t3 - Stromstärke berechnen\n");
                    Console.WriteLine("Wählen sie eine rechnung aus");
                    string rechnung = Console.ReadLine();

                    if (rechnung == "1")
                    {
                        try
                        {

                            Console.Clear();

                            Console.WriteLine("----------Widerstand----------");

                            Console.WriteLine("Gib die Spannung an.");
                            double Spannung = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Gib die Stromstärke an.");
                            double Stromstärke = Convert.ToDouble(Console.ReadLine());

                            double ergebnis = (Spannung / Stromstärke);
                            Console.WriteLine("Der Widerstand beträgt {0:F2}.", ergebnis);

                            Console.Read();


                        }
                        catch
                        {
                            Console.WriteLine("flasche eingabe");
                            Console.ReadKey();
                            Console.Clear();

                        }





                    }
                    else if (rechnung == "2")
                    {
                        try
                        {

                            Console.Clear();

                            Console.WriteLine("-----------Spannung----------");
                            Console.WriteLine("Gib die Stromstärke an.");
                            double Stromstärke2 = Convert.ToDouble(Console.ReadLine());


                            Console.WriteLine("Gib den Widerstand an.");
                            double Widerstand2 = Convert.ToDouble(Console.ReadLine());


                            double ergebnis2 = (Widerstand2 * Stromstärke2);
                            Console.WriteLine("Die Spannung beträgt {0:F2}", ergebnis2);

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
                    else if (rechnung == "3")
                    {
                        try
                        {

                            Console.Clear();
                            Console.WriteLine("----------Stromstärke----------");

                            Console.WriteLine("Gib den Widerstand an.");
                            double Widerstand3 = Convert.ToDouble(Console.ReadLine());


                            Console.WriteLine("Gib die Spannung an.");
                            double Spannung3 = Convert.ToDouble(Console.ReadLine());
                            double ergebnis3 = (Spannung3 / Widerstand3);

                            Console.WriteLine("Die Stromstärke beträgt {0:F2}", ergebnis3);

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
                    else if (rechnung == "exit")
                    {
                        Environment.Exit(0);

                        break;
                    }
                    else if (rechnung == "submenü")
                    {
                        Console.Clear();
                        ETMenue.ETSubMenue();
                    }
                    Console.Clear();
                }


            }


        }
    }
}











