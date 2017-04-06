using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Plochki_v_Gradinka
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqSide = double.Parse(Console.ReadLine());
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double benchA = double.Parse(Console.ReadLine());
            double benchB = double.Parse(Console.ReadLine());
            
            double sqArea = sqSide * sqSide;
            double bench = benchA * benchB;
            double tile = sideA * sideB;

            Console.WriteLine((sqArea-bench)/tile);
            Console.WriteLine(((sqArea-bench)/tile)*0.2);
        }
    }
}
