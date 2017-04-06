using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dve = 0;
            int dvedve = 0;
            for (int top = 0; top < n; top++)
            {
                Console.Write(new string('.', ((((3 * n) - 2) / 2) - top)));
                Console.Write("/");
                Console.Write(new string (' ', dve));
                Console.Write(@"\");
                Console.WriteLine(new string('.', ((((3 * n) - 2) / 2) - top)));
                dve += 2;
            }
            Console.Write(new string ('.', n/2));
            Console.Write(new string('*', 2*n));
            Console.WriteLine(new string ('.', n/2));

            for (int mid = 0; mid < 2 * n; mid++)
            {
                Console.Write(new string('.', n / 2));
                Console.Write("|");
                Console.Write(new string('\\', (2 * n)-2));
                Console.Write("|");
                Console.WriteLine(new string('.', n / 2));
            }

            for (int bot = 0; bot < n/2; bot++)
            {
                Console.Write(new string('.', n / 2 - bot));
                Console.Write("/");
                Console.Write(new string('*', (2 * n) - 2+dvedve));
                Console.Write("\\");
                Console.WriteLine(new string('.', n / 2 - bot));
                dvedve += 2;
            }




        }
    }
}
