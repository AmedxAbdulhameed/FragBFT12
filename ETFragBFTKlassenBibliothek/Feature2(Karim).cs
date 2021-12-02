using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFragBFTKlassenBibliothek
{
    public class Feature2
    {
        public static void Feature2Funcion2()

        {
            string Ausw;
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                     "                              >>> Ohmsches Gesetz <<<\n" +
                                     "------------------------------------------------------------------------------------\n\n");

            Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
            Console.WriteLine("\t1 - Widerstand");
            Console.WriteLine("\t2 - Spannung");
            Console.WriteLine("\t3 - Stromstärke");
            Console.Write("Eingabe:");
            Ausw = Console.ReadLine();
           
            switch (Ausw)
            {

                case "1":
                    Console.Clear();

                    Console.WriteLine("----------Widerstand----------");

                    Console.WriteLine("Gib die Spannung an.");
                    double Spannung = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Gib die Stromstärke an.");
                    double Stromstärke = Convert.ToDouble(Console.ReadLine());

                    double ergebnis = (Spannung / Stromstärke);
                    Console.WriteLine("Der Widerstand beträgt {0:F2}.", ergebnis);

                    Console.Read();
                    Console.Clear(); 
                     
                    break;

                case "2":
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

                    break;

                case "3":
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


                    break;


                    























            }

        }
    }
}
