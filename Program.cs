using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace Provodnik
{
    internal class Program
    {
        static void Main()
        {

            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                Explorer.DiscInfo();
                Strelka.Show();
                key = Console.ReadKey();
                Console.Clear();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Explorer.Dir();
                }
            }
        }
    }
}