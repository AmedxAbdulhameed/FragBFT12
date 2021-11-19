using System;

namespace KonsolenExtrasBibliothek
{
    public class ConsoleExtras
    {
        public static void ClearCurrentConsoleLine(int from, int to)
        {
            /*Diese Methode löscht alle Zeichen innerhalb eines Zeilenabschnitts.*/

            for (int i = to; i >= from; i--)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            Console.SetCursorPosition(0, from);
        }
    }
}
