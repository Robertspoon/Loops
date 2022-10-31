using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops");
            Console.WriteLine();

            int[] ammo = new int[5];
            ammo[0] = 6;
            ammo[1] = 12;
            ammo[2] = 2;
            ammo[3] = 35;
            ammo[4] = 7;

            int start = 0;
            int end = 4;

            int i = start;

            // count from starts...end

            while (i <= end)
            {
                Console.Write(ammo[i] + ", ");
                i = i + 1;
            }

            Console.ReadKey(true);
        }
    }
}
