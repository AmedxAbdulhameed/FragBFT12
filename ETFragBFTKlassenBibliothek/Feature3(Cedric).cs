using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETFragBFTKlassenBibliothek
{
    public class Feature3
    {
        public static void Feature3Funcion3()
        {
            

           
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                     "                              >>> Spannungsfall <<<\n" +
                                     "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Bitte geben Sie die Werte für die Formel(keine anderen eingaben möglivh oder Formeln )");


                try
                {
                

                    Console.WriteLine("Bitte geben Sie I = Stromkreis in A  ein");
                    double zahl1 = Convert.ToDouble(Console.ReadLine());
                         
                    Console.WriteLine("Bitte geben Sie l= Leistungslänge in m ein");
                    double zahl2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Bitte geben Sie y = spezifischer elektischer Leitwert des Leiters in m/mm^2* ohm ein");
                    double zahl3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Bitte geben Sie A = Ampere ein");
                    double zahl4 = Convert.ToDouble(Console.ReadLine());

                    double ergebnis = 0;

                    ergebnis = zahl1 * zahl2 + 2 / zahl3 * zahl4;
                    Console.WriteLine($"Der Spannungsfall ist :{ergebnis} ");

                    Console.Read();
                    Console.Clear();
                    return;
                 

                }
                catch
                {
                    Console.WriteLine("flasche eingabe");
                    Console.ReadKey();
                    Console.Clear();


                }
             



        }

    }
}
