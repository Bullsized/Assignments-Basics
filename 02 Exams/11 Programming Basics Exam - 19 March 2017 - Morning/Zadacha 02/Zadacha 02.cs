using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_02
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cups = decimal.Parse(Console.ReadLine());
            decimal workers = decimal.Parse(Console.ReadLine());
            decimal days = decimal.Parse(Console.ReadLine());

            decimal hours = workers * days * 8M;
            decimal realCups = Math.Floor(hours / 5M);

            if (realCups >= cups)
            {
                decimal extraMoney = (realCups - cups) * 4.2M;
                Console.WriteLine("{0:f2} extra money", extraMoney);
            }
            else if (realCups < cups)
            {
                decimal losses = (cups - realCups) * 4.2M;
                Console.WriteLine("Losses: {0:f2}", losses);
            }
        }
    }
}