using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            decimal price = 0M;

            if (100 >= money)
            {
                Console.WriteLine("Economy class");
                if (season == "Summer")
                {
                    price = (money * 0.35M);
                    Console.WriteLine("Cabrio - {0:f2}", price);
                }
                else if (season == "Winter")
                {
                    price = (money * 0.65M);
                    Console.WriteLine("Jeep - {0:f2}", price);
                }
            }
            else if (500 >= money && money > 100)
            {
                Console.WriteLine("Compact class");
                if (season == "Summer")
                {
                    price = (money * 0.45M);
                    Console.WriteLine("Cabrio - {0:f2}", price);
                }
                else if (season == "Winter")
                {
                    price = (money * 0.8M);
                    Console.WriteLine("Jeep - {0:f2}", price);
                }
            }
            else if (money > 500)
            {
                Console.WriteLine("Luxury class");
                if (season == "Summer" || season == "Winter")
                {
                    price = (money * 0.9M);
                    Console.WriteLine("Jeep - {0:f2}", price);
                }
            }
        }
    }
}