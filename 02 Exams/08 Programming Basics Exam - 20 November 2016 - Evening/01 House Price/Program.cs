using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal kuhnq = decimal.Parse(Console.ReadLine());
            decimal cena = decimal.Parse(Console.ReadLine());

            decimal y = (x * 0.1M) + x; //2ra staq
            decimal z = (y * 0.1M) + y; //3ta staq
            decimal banq = x/2; //banq
            decimal sum = x + y + z + kuhnq + banq; //sum

            decimal total = (sum * 0.05M) + sum;
            decimal answer = total * cena;

            Console.WriteLine("{0:f2}", answer);
        }
    }
}