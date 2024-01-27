using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Provodnik
{
    internal static class Explorer
    {
        public static void DiscInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                double dfsize = d.TotalFreeSpace;
                double dsize = d.TotalSize;
                Console.WriteLine("  Drive {0}", d.Name);
                if (d.IsReady == true)
                {
                    Console.WriteLine("    Доступно: " + Math.Round(dfsize / 1073741824, 2) + " Гб из " + Math.Round(dsize / 1073741824, 2) + " Гб");
                }
            }
        }

        public static void Dir()
        {
                foreach (var path in Directory.GetDirectories("C:\\Users\\Doratorio"))
                {
                    Console.WriteLine("  " + System.IO.Path.GetFileName(path));
                }
        }
    }
}
