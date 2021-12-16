using System;

namespace WIFragBFTKlassenBibliothek
{
    class Feature18
    {
        public static void Feature18Funcion1()
        {
            double StartKapital;
            double Zinsen;
            double Jahre;
            double Endkapital;


            Console.WriteLine("Geben Sie Ihr Kapital in EUR an");
            StartKapital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie viele Jahre wollen Sie anlegen?");
            Jahre = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben Sie Ihren Zinssatz pro Jahr ein");
            Zinsen = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Die Ergebnisse für die folgenden Jahre sind");



            double TempPSatz = 1 + ((double)Zinsen / 100);
            double ErgPSatz = Math.Pow(TempPSatz, Jahre);

            Endkapital = StartKapital * ErgPSatz;
            Zinsen = Endkapital - StartKapital;

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Ihr Endergebnis ist: {Endkapital:f2}EUR");
            Console.WriteLine("----------------------------------------");
            Console.ReadKey();
            Console.Clear();

        }
    }
}


