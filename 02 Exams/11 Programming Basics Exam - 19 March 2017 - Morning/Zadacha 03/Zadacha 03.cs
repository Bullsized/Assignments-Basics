using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_03
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 1000)
            {
                if (season == "Summer")
                {
                    Console.WriteLine("Alaska - Camp - {0:f2}", budget * 0.65M);
                }
                else if (season == "Winter")
                {
                    Console.WriteLine("Morocco - Camp - {0:f2}", budget * 0.45M);

                }
            }
            else if (1000 < budget && budget <= 3000)
            {
                if (season == "Summer")
                {
                    Console.WriteLine("Alaska - Hut - {0:f2}", budget * 0.8M);

                }
                else if (season == "Winter")
                {
                    Console.WriteLine("Morocco - Hut - {0:f2}", budget * 0.6M);
                }
            }
            else if (3000 < budget)
            {
                if (season == "Summer")
                {
                    Console.WriteLine("Alaska - Hotel - {0:f2}", budget * 0.9M);

                }
                else if (season == "Winter")
                {
                    Console.WriteLine("Morocco - Hotel - {0:f2}", budget * 0.9M);
                }
            }
        }
    }
}