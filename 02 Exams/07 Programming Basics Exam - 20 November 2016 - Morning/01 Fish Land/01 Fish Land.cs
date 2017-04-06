using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fish_Land
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal d = decimal.Parse(Console.ReadLine());
            decimal e = decimal.Parse(Console.ReadLine());
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());

            decimal cenaPalamud = a * (d + (d * 0.6M));
            decimal cenaSafrid = b * (e + (e * 0.8M));
            decimal cenaMidi = c * 7.50M;
            decimal cena = cenaMidi + cenaPalamud + cenaSafrid;

            Console.WriteLine("{0:f2}", cena);
        }
    }
}