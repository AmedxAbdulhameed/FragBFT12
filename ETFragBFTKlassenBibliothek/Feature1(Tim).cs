using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;
namespace ETFragBFTKlassenBibliothek
{
    public class Feature1
    {
        public static void Feature1Funcion1()
        
        {
            

            {      Console.WriteLine
                   (FiggleFonts.Slant.Render("BFTMultiTool"));


                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Bruttorechner <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
                
                double a; // Nettobetrag

                const double b = 1.07; // MwSt 7%(1.07) wenn man die MwSt dazurechnen will

                const double c = 1.19; // MwSt 19%(1.19) wenn man die MwSt dazurechen will

                Console.Write("Nettobetrag in Euro : ");
 
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Brutto mit 7% MwSt : {0}\n", a * b);

                Console.Write("Brutto mit 19% MwSt : {0}", a * c);

                Console.ReadLine();
                Console.Clear();
               
            }
               
           


        }
    }
}
