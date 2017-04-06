using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Delenie_bez_Ostatuk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal p2 = 0M;
            decimal p3 = 0M;
            decimal p4 = 0M;

            for (int cycle = 0; cycle < n; cycle++)
            {
                int m = int.Parse(Console.ReadLine());

                if (m % 2 == 0)
                {
                    p2++;
                }
                if (m % 3 == 0)
                {
                    p3++;
                }
                if (m % 4 == 0)
                {
                    p4++;
                }
            }
            decimal ansP2 = (p2 / n) * 100M;
            decimal ansP3 = (p3 / n) * 100M;
            decimal ansP4 = (p4 / n) * 100M;

            Console.WriteLine("{0:f2}%\n{1:f2}%\n{2:f2}%", ansP2, ansP3, ansP4);
        }
    }
}