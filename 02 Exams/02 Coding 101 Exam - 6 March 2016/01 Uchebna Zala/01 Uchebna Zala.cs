using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Uchebna_Zala
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal w = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());

            decimal width = h * 100 - 100;
            decimal row = Math.Floor(width / 70);

            decimal height = w * 100;
            decimal column = Math.Floor(height / 120);

            var answer = (row * column) -3;
            Console.WriteLine(answer);
        }
    }
}