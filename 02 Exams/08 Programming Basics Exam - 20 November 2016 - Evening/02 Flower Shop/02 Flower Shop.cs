using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal magnolii = decimal.Parse(Console.ReadLine());
            decimal ziumbiuli = decimal.Parse(Console.ReadLine());
            decimal rozes = decimal.Parse(Console.ReadLine());
            decimal kaktusi = decimal.Parse(Console.ReadLine());
            decimal cena = decimal.Parse(Console.ReadLine());

            decimal magn = magnolii * 3.25M;
            decimal zium = ziumbiuli * 4M;
            decimal rozi =  rozes * 3.50M;
            decimal kakt = kaktusi * 8;

            decimal sum = magn + zium + rozi + kakt;
            decimal procentat = sum -(sum * 0.05M);

            if (cena <= procentat)
            {
                var novo = procentat - cena;
                Console.WriteLine("She is left with {0} leva.", Math.Floor(novo));
            }
            else
            {
                var novo = cena - procentat;
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(novo));
            }
        }
    }
}
