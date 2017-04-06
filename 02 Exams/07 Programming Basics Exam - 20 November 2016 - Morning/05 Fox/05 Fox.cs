using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int wide = (2 * n) + 3;
            int edno = 0;
            int dve = 4;
            int tri = 4;

            for (int top = 1; top <= n; top++)
            {
                Console.Write(new string('*', top));
                Console.Write(@"\");
                Console.Write(new string('-', wide - dve));
                Console.Write("/");
                Console.WriteLine(new string('*', top));
                dve += 2;
            }

            for (int mid = 0; mid < n / 3; mid++)
            {
                Console.Write("|");
                Console.Write(new string('*', ((n - 1) / 2) + mid));
                Console.Write(@"\");
                Console.Write(new string('*', n - edno));
                Console.Write("/");
                Console.Write(new string('*', ((n - 1) / 2) + mid));
                Console.WriteLine("|");
                edno += 2;
            }

            for (int bot = 1; bot <= n; bot++)
            {
                Console.Write(new string('-', bot));
                Console.Write(@"\");
                Console.Write(new string('*', wide - tri));
                Console.Write("/");
                Console.WriteLine(new string('-', bot));
                tri += 2;
            }
        }
    }
}