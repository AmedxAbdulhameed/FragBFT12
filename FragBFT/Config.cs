using System;
using FragBFTKlassenBibliothek;

namespace FragBFT
{
    class Config
    {
        static void Main()
        {
            //Die Größe des Konsolenfensters wird an den Bildschirm angepasst.
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            //Schriftfarbe wird auf Grün gesetzt.
            Console.ForegroundColor = ConsoleColor.Green;

            //Der Schrifthintergrund kann geändert werden.
            //Console.BackgroundColor = ConsoleColor.DarkRed;

            //Aufruf des Hauptmenüs.
            FragBFTKlassenBibliothek.Hauptmenue.HauptmenueAufruf();

        }
    }
}
