using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area = {x * x * Math.PI}");
            Console.WriteLine($"Perimeter = {2 * Math.PI * x}");

        }
    }
}