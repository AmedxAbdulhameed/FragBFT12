using System;

namespace Zinsrechner_von_Bjar_rashid
{
    class Program
    {
        static void Main(string[] args)
        {
            double StartKapital;
            double Zinsen;
            double Jahre;
            double Endkapital;


            Console.WriteLine("Geben Sie Ihr Kapital an");
            StartKapital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie viele Jahre wollen sie ausrechenen");
            Jahre = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben Sie Ihre Zinsen ein");
            Zinsen = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Die Ergebnisse für die folgenden Jahre sind");



            double TempPSatz = 1 + ((double)Zinsen / 100);
            double ErgPSatz = Math.Pow(TempPSatz, Jahre);

            Endkapital = StartKapital * ErgPSatz;
            Zinsen = Endkapital - StartKapital;

            Console.WriteLine($"ihr endergebnis ist: {Endkapital:f5}");
            Console.ReadKey();


        }
    }
}


