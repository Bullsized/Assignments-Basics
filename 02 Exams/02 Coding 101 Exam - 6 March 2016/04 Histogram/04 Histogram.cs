using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int cycle = 0; cycle < n; cycle++)
            {
                int digit = int.Parse(Console.ReadLine());

                if (digit <= 199)
                {
                    p1++;
                }
                else if (200 <= digit && digit <= 399)
                {
                    p2++;

                }
                else if (400 <= digit && digit <= 599)
                {
                    p3++;

                }
                else if (600 <= digit && digit <= 799)
                {
                    p4++;

                }
                else if (800 <= digit)
                {
                    p5++;

                }
            }

            double p1perc = ((double)p1 * 100) / n;
            double p2perc = ((double)p2 * 100) / n;
            double p3perc = ((double)p3 * 100) / n;
            double p4perc = ((double)p4 * 100) / n;
            double p5perc = ((double)p5 * 100) / n;

            Console.WriteLine("{0:f2}%", p1perc);
            Console.WriteLine("{0:f2}%", p2perc);
            Console.WriteLine("{0:f2}%", p3perc);
            Console.WriteLine("{0:f2}%", p4perc);
            Console.WriteLine("{0:f2}%", p5perc);
        }
    }
}
