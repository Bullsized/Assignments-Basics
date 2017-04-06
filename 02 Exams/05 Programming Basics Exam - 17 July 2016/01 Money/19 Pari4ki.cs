using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Pari4ki
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            double x1 = x * 1168;
            double y2 = y * 0.15;
            double y1 = y2 * 1.76;
            double x2 = (x1 + y1) / 1.95; 
            double comm = x2 * (z / 100);
            double result = x2 - comm;
            Console.WriteLine(result);
        }
    }
}
