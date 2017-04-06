using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

           /* if (y < -5 || y > 3 || x < 2 || x > 12)
            { Console.WriteLine("out"); }
            else if (x > 10 && y < -3)
            { Console.WriteLine("out"); }
            else if (x > 10 && y > 1)
            { Console.WriteLine("out"); }
            else if (x < 4 && y > 3)
            { Console.WriteLine("out"); }
            else if (x < 4 && y < -3)
            { Console.WriteLine("out"); }
            else
            { Console.WriteLine("in"); } */

            if ((x >= 4 && x <= 10) && (y >= -5 && y <= -3) ||
                (x >= 2 && x <= 12) && (y >= -3 && y <= 1) ||
                (x >= 4 && x <= 10) && (y >= 1 && y <= 3))
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}