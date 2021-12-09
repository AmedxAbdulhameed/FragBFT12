using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYFragBFTKlassenBibliothek
{
    class feature7
    {
        internal static void Feature7Funcion1()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Feature7 wird ausgeführt");


                double kmh = 0, mps = 0, mach = 0, neustart = 0, Auswahl1 = 0;

                Console.WriteLine("Was möchten sie umrechnen, für kmh in meter pro sek drücken sie die 1 für meter pro sek in kmh 2 ");
                Console.WriteLine("mach in kmh 3, kmh in mach 4");
                Console.WriteLine("mach in meter pro sek 5,meter pro sek 6");

                Auswahl1 = Convert.ToDouble(Console.ReadLine());

                if (Auswahl1==1)
                {
                    Console.WriteLine("Bitte geben sie die kmh ein");


                    kmh = Convert.ToDouble(Console.ReadLine());

                    mps = kmh / 3.6;
                    Console.WriteLine(mps);
                    Console.WriteLine("meter pro sek");
                }

                if (Auswahl1 == 2)
                {
                    

                    Console.WriteLine("Bitte geben sie die meter pro sek ein");
                    mps = Convert.ToDouble(Console.ReadLine());

                    kmh = mps * 3.6;

                    Console.WriteLine(kmh);
                    Console.WriteLine("kmh");

                }


                if (Auswahl1 == 3)
                {
                    Console.WriteLine("Bitte geben sie die kmh ein");
                    mach = Convert.ToDouble(Console.ReadLine());

                    kmh = mach / 1235;

                    Console.WriteLine(kmh);
                    Console.WriteLine("kmh");
                }

                if (Auswahl1 == 4)
                {
                    Console.WriteLine("Bitte geben sie die kmh ein");
                    kmh = Convert.ToDouble(Console.ReadLine());

                    mach = kmh * 1235;
                    Console.WriteLine(mach);
                    Console.WriteLine("mach");

                   
                }

                if (Auswahl1 == 5)
                {Console.WriteLine("Bitte geben sie meter pro sek ein");
                    mps = Convert.ToDouble(Console.ReadLine());
                    mach = mps * 343;

                    Console.WriteLine(mach);
                    Console.WriteLine("mach");            
                }
                
                if (Auswahl1 == 6)
                {
                    


                    Console.WriteLine("Bitte geben sie die meter pro sek ein");
                    mps = Convert.ToDouble(Console.ReadLine());

                    mps =  mach / 343;

                    Console.WriteLine(mps);
                    Console.WriteLine("meter pro sek");




                }

















                Console.WriteLine("möchten sie das Feature neustarten wenn ja drücken sie die 1 wenn nein drücken sie die 2 ");
                neustart = Convert.ToDouble(Console.ReadLine());


            } while (neustart==1);

           




        }
    }
}
