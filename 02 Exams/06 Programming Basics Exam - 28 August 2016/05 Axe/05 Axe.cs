using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dve = 0;

            Console.Write(new string('-', 3 * n));
            Console.Write("**");
            Console.WriteLine(new string('-', (2 * n) - 2)); // top row

            for (int top1 = 1; top1 <= n - 1; top1++)   //mid do drujkata NA TSLATA DRUJKATA
            {
                Console.Write(new string('-', 3 * n));
                Console.Write("*");
                Console.Write(new string('-', top1));
                Console.Write("*");
                Console.WriteLine(new string('-', (2 * n) - 2 - top1));
            }

            for (int mid = 0; mid < n / 2; mid++) //drujkata
            {
                Console.Write(new string('*', (3 * n) + 1));
                Console.Write(new string('-', n - 1));
                Console.Write("*");
                Console.WriteLine(new string('-', n - 1));
            }

            for (int bottom1 = 0; bottom1 <= (n / 2) - 1; bottom1++) // pod drujkata
            {
                if (bottom1 == n / 2 - 1 && n % 2 == 0)
                {
                    Console.Write(new string('-', (3 * n) - bottom1));
                    Console.Write(new string('*', (2 * n) - 1));
                    Console.WriteLine(new string('-', (n - 1) - bottom1));
                    break;
                }
                else if (bottom1 == n / 2 - 1 && n % 2 != 0)
                {
                    Console.Write(new string('-', (3 * n) - bottom1));
                    Console.Write(new string('*', (2 * n) - 2));
                    Console.WriteLine(new string('-', (n - 1) - bottom1));
                    break;
                }
                Console.Write(new string('-', (3 * n) - bottom1));
                Console.Write("*");
                Console.Write(new string('-', (n - 1) + dve));
                Console.Write("*");
                Console.WriteLine(new string('-', (n - 1) - bottom1));

                dve += 2;
            }
        }
    }
}