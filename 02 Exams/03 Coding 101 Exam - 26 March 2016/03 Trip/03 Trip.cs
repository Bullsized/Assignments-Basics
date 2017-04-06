using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            if (money <= 100) //bg
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    decimal answer = money * 0.3M;
                    Console.WriteLine("Camp - {0:f2}", answer);
                }
                else if (season == "winter")
                {
                    decimal answer = money * 0.7M;
                    Console.WriteLine("Hotel - {0:f2}", answer);
                }
            }
            else if (100 < money && money <= 1000) //balcans
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    decimal answer = money * 0.4M;
                    Console.WriteLine("Camp - {0:f2}", answer);
                }
                else if (season == "winter")
                {
                    decimal answer = money * 0.8M;
                    Console.WriteLine("Hotel - {0:f2}", answer);
                }
            }
            else //europe
            {
                Console.WriteLine("Somewhere in Europe");
                decimal answer = money * 0.9M;
                Console.WriteLine("Hotel - {0:f2}", answer);
            }
        }
    }
}