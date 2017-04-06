using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Game_of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal result = 0M;

            decimal xInv = 0M;
            decimal x1 = 0M;
            decimal x2 = 0M;
            decimal x3 = 0M;
            decimal x4 = 0M;
            decimal x5 = 0M;

            for (int cycle = 0; cycle < n; cycle++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x < 0 || x > 50)
                {
                    xInv++;
                    result = result / 2M;
                }
                else if (x >= 0 && x <= 9)
                {
                    x1++;
                    result= result + (0.2M*x);
                }
                else if (x >= 10 && x <= 19)
                {
                    x2++;
                    result = result + (0.3M * x);
                }
                else if (x >= 20 && x <= 29)
                {
                    x3++;
                    result = result + (0.4M * x);
                }
                else if (x >= 30 && x <= 39)
                {
                    x4++;
                    result = result + 50;
                }
                else if (x >= 40 && x <= 50)
                {
                    x5++;
                    result = result + 100;
                }
            }
            Console.WriteLine("{0:f2}", result);
            Console.WriteLine("From 0 to 9: {0:f2}%", (x1/n) * 100);
            Console.WriteLine("From 10 to 19: {0:f2}%", (x2/n) * 100);
            Console.WriteLine("From 20 to 29: {0:f2}%", (x3/n) * 100);
            Console.WriteLine("From 30 to 39: {0:f2}%", (x4/n) * 100);
            Console.WriteLine("From 40 to 50: {0:f2}%", (x5/n) * 100);
            Console.WriteLine("Invalid numbers: {0:f2}%", (xInv/n) * 100);
        }
    }
}
