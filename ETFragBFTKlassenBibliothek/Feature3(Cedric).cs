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

            Console.WriteLine("Bitte geben Sie I ein");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie l ein");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie y ein");
            double zahl3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie A ein");
            double zahl4 = Convert.ToDouble(Console.ReadLine());

            double ergebnis= 0;

            ergebnis = zahl1 * zahl2 + 2 / zahl3 * zahl4;
            Console.WriteLine($"Der Spannungsfall ist :{ergebnis} ");

            Console.Read();
            Console.Clear();
        }

    }
}
