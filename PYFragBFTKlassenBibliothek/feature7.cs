using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace PYFragBFTKlassenBibliothek
{
    class feature7
    {
        internal static void Feature7Funcion1()
        {
           

            double Neustart = 0;
            do
            {
                
                Console.Clear();

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("FragBFT"));

                //Konsolentitel wird geändert.
                Console.Title = "FragBFT";

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tzurück zum Hauptmenü");

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Feature7 wird ausgeführt  <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");


                


                double kmh = 0, mps = 0, mach = 0, Auswahl1 = 0;

                Console.WriteLine("Was möchten sie umrechnen, für kmh in meter pro sek drücken sie die 1 für meter pro sek in kmh 2 ");
                Console.WriteLine("mach in kmh 3, kmh in mach 4");
                Console.WriteLine("mach in meter pro sek 5,meter pro sek 6");

                Auswahl1 = Convert.ToDouble(Console.ReadLine());

                if (Auswahl1==1)
                {
                    Console.WriteLine("Bitte geben sie die kmh ein");

                    Console.WriteLine("-------------------------------------------------");

                    kmh = Convert.ToDouble(Console.ReadLine());

                    mps = kmh / 3.6;
                    Console.WriteLine(mps);
                    Console.WriteLine("meter pro sek");
                }

                if (Auswahl1 == 2)
                {
                    

                    Console.WriteLine("Bitte geben sie die meter pro sek ein");
                    Console.WriteLine("-------------------------------------------------");
                    mps = Convert.ToDouble(Console.ReadLine());

                    kmh = mps * 3.6;

                    Console.WriteLine(kmh);
                    Console.WriteLine("kmh");

                }


                if (Auswahl1 == 3)
                {
                    Console.WriteLine("Bitte geben sie die kmh ein");
                    Console.WriteLine("-------------------------------------------------");
                    mach = Convert.ToDouble(Console.ReadLine());

                    kmh = mach / 1235;

                    Console.WriteLine(kmh);
                    Console.WriteLine("kmh");
                }

                if (Auswahl1 == 4)
                {
                    Console.WriteLine("Bitte geben sie die kmh ein");
                    Console.WriteLine("-------------------------------------------------");
                    kmh = Convert.ToDouble(Console.ReadLine());

                    mach = kmh * 1235;
                    Console.WriteLine(mach);
                    Console.WriteLine("mach");

                   
                }

                if (Auswahl1 == 5)
                {Console.WriteLine("Bitte geben sie meter pro sek ein");
                    Console.WriteLine("-------------------------------------------------");
                    mps = Convert.ToDouble(Console.ReadLine());
                    mach = mps * 343;

                    Console.WriteLine(mach);
                    Console.WriteLine("mach");            
                }
                
                if (Auswahl1 == 6)
                {
                    


                    Console.WriteLine("Bitte geben sie die meter pro sek ein");
                    Console.WriteLine("-------------------------------------------------");
                    mps = Convert.ToDouble(Console.ReadLine());

                    mps =  mach / 343;

                    Console.WriteLine(mps);
                    Console.WriteLine("meter pro sek");




                }












                Console.WriteLine("------------------------------------------------------------------------------------------------");




                Console.WriteLine("möchten sie das Feature neustarten wenn ja drücken sie die 1 wenn nein drücken sie die 2 ");
                Neustart = Convert.ToDouble(Console.ReadLine());


            } while (Neustart == 1);

           




        }
    }
}
