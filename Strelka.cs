using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provodnik
{
    internal class Strelka
    {
        public static int Show()
        {
            int pos = 0;
            int maxpos = 36;
            ConsoleKeyInfo skey;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                skey = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                if (skey.Key == ConsoleKey.UpArrow && pos != 0)
                {
                    pos--;
                }
                if (skey.Key == ConsoleKey.DownArrow && pos != maxpos)
                {
                    pos++;
                }
            } while (skey.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}
