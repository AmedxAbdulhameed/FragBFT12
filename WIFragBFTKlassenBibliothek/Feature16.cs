using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIFragBFTKlassenBibliothek
{
    class Feature16
    {
        public static void Feature16Funcion1()
        {
            double Eingabe = 1, Lst = 0, Dst = 0, Ntgh;
            string jn;

            do
            {
                Console.WriteLine("Bitte Bruttogehalt eingeben");
                Eingabe = Convert.ToDouble(Console.ReadLine());
                if (Eingabe <= 11000) Lst = 0;
                else if (Eingabe <= 18000) Lst = (Eingabe - 11000) * 0.25;
                else if (Eingabe <= 31000) Lst = (18000 - 11000) * 0.25 + (Eingabe - 18000) * 0.35;
                else if (Eingabe <= 60000) Lst = (18000 - 11000) * 0.25 + (31000 - 18000) * 0.35 + (Eingabe - 31000) * 0.42;
                else if (Eingabe <= 90000) Lst = (18000 - 11000) * 0.25 + (31000 - 18000) * 0.35 + (60000 - 31000) * 0.42 + (Eingabe - 60000) * 0.48;
                else if (Eingabe <= 1000000) Lst = (18000 - 11000) * 0.25 + (31000 - 18000) * 0.35 + (60000 - 31000) * 0.42 + (90000 - 60000) * 0.48 + (Eingabe - 90000) * 0.50;
                else Lst = (18000 - 11000) * 0.25 + (31000 - 18000) * 0.35 + (60000 - 31000) * 0.42 + (90000 - 60000) * 0.48 + (1000000 - 90000) * 0.50 + (Eingabe - 1000000) * 0.55;

                Dst = (Lst / Eingabe) * 100;
                Ntgh = Eingabe - Lst;
                Console.WriteLine("Lohnsteuer");
                Console.WriteLine(Lst);
                Console.WriteLine("Nettogehalt");
                Console.WriteLine(Ntgh);
                Console.WriteLine("Durchschnittsteuersatz");
                Console.WriteLine(Dst);



                Console.WriteLine("Wollen Sie das Programm wiederholen? (j/n)");

                jn = Console.ReadLine();


            } while (jn=="j");
        }
    }
}
