using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Stop_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var nula = 0;
            var edno = 1;
            var dve = 0;
            var novanula = 0;
            var novodve = 0;

            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', 2*n + 1));
            Console.WriteLine(new string('.', n + 1));

            for (int top = 0; top < n; top++)
            {
                Console.Write(new string('.', n - nula));
                Console.Write("//");
                Console.Write(new string('_', ((2*n)-1+dve)));
                Console.Write(@"\\");
                Console.WriteLine(new string('.', n - nula));
                nula++;
                dve = dve + 2;
            }
            Console.Write("//");
            Console.Write(new string('_', ((2 * n) - 3)));
            Console.Write("STOP!");
            Console.Write(new string('_', ((2 * n) - 3)));
            Console.WriteLine(@"\\");

            for (int bottom = 0; bottom < n; bottom++)
            {
                Console.Write(new string('.', novanula));
                Console.Write(@"\\");
                Console.Write(new string('_', (((4 * n) - 1) - novodve)));
                Console.Write("//");
                Console.WriteLine(new string('.', novanula));

                novanula++;
                novodve = novodve + 2;
            }
        }
    }
}