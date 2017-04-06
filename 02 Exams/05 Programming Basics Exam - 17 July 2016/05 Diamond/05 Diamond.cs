using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dve = 0;
            int dvedve = 4;

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n)); // top row

            for (int top1 = 1; top1 < n; top1++)
            {
                Console.Write(new string('.', n - top1));
                Console.Write("*");
                Console.Write(new string('.', n * 3 + dve));
                Console.Write("*");
                Console.WriteLine(new string('.', n - top1));
                dve += 2;
            }

            Console.WriteLine(new string('*', 5 * n)); //mid row

            for (int bottom1 = 1; bottom1 < ((3*n)+1-n); bottom1++)
            {
                Console.Write(new string('.', bottom1));
                Console.Write("*");
                Console.Write(new string('.', 5*n - dvedve));
                Console.Write("*");
                Console.WriteLine(new string('.', bottom1));
                dvedve += 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('.', (5*n-(n-2))/2), new string('*', n - 2)); // bottom row
        }
    }
}