using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIFragBFTKlassenBibliothek
{
    class Feature19
    {
        internal static void Feature19Funcion1()
        {
            Console.WriteLine("Immobilienrechner");

            Console.WriteLine("Geben sie ihr Startkapital in Euro an:");

            int Startkapital = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Geben sie den Gesamtpreis der Immobilie an:");

            int Gesamtpreis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ihre Restliche Bausparsumme beträgt :");

            int Bausparsumme = Gesamtpreis - Startkapital;

            Console.WriteLine(Gesamtpreis - Startkapital);

            

            Console.WriteLine("Geben sie ihren Zinnssatz in % ein");

            int Zinnssatz = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ihr Zinnssatz in Euro :");

            Console.WriteLine(Bausparsumme /100 * Zinnssatz );

            Console.ReadLine();

            Console.WriteLine("Ihr Restlich zu bezahlender Betrag beträgt :");

            int Betrag = Bausparsumme / 100 * Zinnssatz + Bausparsumme ;

            Console.WriteLine(Betrag / 100 * Zinnssatz + Bausparsumme );

            Console.WriteLine("Geben sie ihr möglichen Monatlichen zu Zahlenden Betrag an :");

            Console.ReadLine();


            Console.ReadLine();



            Console.ReadKey();
            Console.Clear();

        }
    }
}

