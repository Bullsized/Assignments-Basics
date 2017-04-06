using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_First
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine()) / 60;
            double c = double.Parse(Console.ReadLine()) / 60;
            double d = double.Parse(Console.ReadLine()) / 60;

            var edno = a * b;
            var dve = ((a * 0.1) + a) * c;
            var tri = (((a * 0.1) + a) - (((a * 0.1) + a) * 0.05)) *d;                           
            var result = edno + dve + tri;
            Console.WriteLine("{0:f2}", result);
        }
    }
}