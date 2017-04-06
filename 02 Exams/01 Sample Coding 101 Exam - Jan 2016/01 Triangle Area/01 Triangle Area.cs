using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            decimal a = 0M;
            if (x2 > x3)
            {
                a = x2 - x3;
            }
            else if (x3 > x2)
            {
                a = x3 - x2;
            }

            decimal h = Math.Abs(y1 - y2);  //math abs-a e lipsval prez cqloto vreme!
            decimal s = (a * h) / 2;

            Console.WriteLine(s);
        }
    }
}
