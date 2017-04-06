using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = int.Parse(Console.ReadLine());
            decimal w = int.Parse(Console.ReadLine());
            decimal m = int.Parse(Console.ReadLine());

            decimal answer = x / (w * m);

            Console.WriteLine(Math.Ceiling(answer));

        }
    }
}
