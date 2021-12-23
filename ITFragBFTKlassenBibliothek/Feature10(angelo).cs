using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace ITFragBFTKlassenBibliothek
{
    internal class Feature10
    {
        internal static void FeatureMenue()
        {
            (int, int) cPosBM = Console.GetCursorPosition();

            Console.WriteLine();

            //ASCII art Logo wird erzeugt.
            Console.WriteLine
                (FiggleFonts.Slant.Render("FragBFT"));

            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                          >>>   Newton's Methode   <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");
        redo:
            Console.WriteLine("Eingabe: Hauptmenü\t->\tzurück zum Hauptmenü");
            Console.WriteLine("Eingabe: Quadratwurzel\t->\tum eine Quadratwurzel zu berechnen");
            Console.WriteLine("Eingabe: Kubikwurzel  \t->\tum eine Kubikwurzel zu berechnen");
            string menueAuswahl = Console.ReadLine().ToLower();
            if (menueAuswahl == "quadratwurzel")
            {
                bool goOn; 
                decimal input = 0;
                do
                {
                    Console.WriteLine("Geben Sie eine zahl ein.");
                    try
                    {
                        input = Convert.ToDecimal(Console.ReadLine());
                        goOn = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("falsche Einegabe");
                        goOn = false;
                    }
                }while (!goOn);

                Console.WriteLine(Newton_sqrt(input)); 
                Console.ReadLine();
                Console.Clear();
            }
            else if (menueAuswahl == "kubikwurzel") 
            {
                bool goOn;
                decimal input = 0;
                do
                {
                    Console.WriteLine("Geben Sie eine zahl ein.");
                    try
                    {
                        input = Convert.ToDecimal(Console.ReadLine());
                        goOn = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("falsche Einegabe");
                        goOn = false;
                    }
                } while (!goOn);

                Console.WriteLine(Newton_cbrt(input));
                Console.ReadLine();
                Console.Clear();
            }
            else if (menueAuswahl == "hauptmenü")
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("falsche Eingabe!\n\n");
                goto redo;
            }
        }
        private static decimal Func(decimal x, decimal a)
        {
            return x * x - a;
        }
        private static decimal DerivFunc(decimal x)
        {
            return 2 * x;
        }
        private static decimal Func1(decimal x, decimal a)
        {
            return x * x * x - a;
        }
        private static decimal DerivFunc1(decimal x)
        {
            return 3 * x * x;
        }
        internal static decimal Newton_sqrt(decimal input, int presizion = 10) // square root
        {
            decimal a = input;
            for (int i = 0; i < presizion; i++)
            {
                input = input - Func(input, a) / DerivFunc(input);
                //Console.WriteLine(input); for debuging
            }
            return input;
        }
        internal static decimal Newton_cbrt(decimal input, int presizion = 15) // cube root
        {
            decimal a = input;
            for (int i = 0; i < presizion; i++)
            {
                input = input - Func1(input, a) / DerivFunc1(input);
                //Console.WriteLine(input); for debuging
            }
            return input;
        }
    }
}
