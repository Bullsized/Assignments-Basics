using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            decimal x = decimal.Parse(Console.ReadLine());

            if (x <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    decimal sum1 = x * 0.75M;
                    decimal sum2 = sum1 * 4M;
                    decimal sum3 = sum2 - (sum2 * 0.1M);
                    Console.WriteLine("{0:f2}", sum3);
                }
                else if (season == "Summer")
                {
                    decimal sum1 = x * 0.9M;
                    decimal sum2 = sum1 * 4M;
                    decimal sum3 = sum2 - (sum2 * 0.1M);
                    Console.WriteLine("{0:f2}", sum3);
                }
                else if (season == "Winter")
                {
                    decimal sum1 = x * 1.05M;
                    decimal sum2 = sum1 * 4M;
                    decimal sum3 = sum2 - (sum2 * 0.1M);
                    Console.WriteLine("{0:f2}", sum3);
                }
            }
            else if (5000 < x && x <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    decimal sum1 = x * 0.95M;
                    decimal sum2 = sum1 * 4M;
                    decimal sum3 = sum2 - (sum2 * 0.1M);
                    Console.WriteLine("{0:f2}", sum3);
                }
                else if (season == "Summer")
                {
                    decimal sum1 = x * 1.1M;
                    decimal sum2 = sum1 * 4M;
                    decimal sum3 = sum2 - (sum2 * 0.1M);
                    Console.WriteLine("{0:f2}", sum3);
                }
                else if (season == "Winter")
                {
                    decimal sum1 = x * 1.25M;
                    decimal sum2 = sum1 * 4M;
                    decimal sum3 = sum2 - (sum2 * 0.1M);
                    Console.WriteLine("{0:f2}", sum3);
                }
            }
            else
            {
                decimal sum1 = x * 1.45M;
                decimal sum2 = sum1 * 4M;
                decimal sum3 = sum2 - (sum2 * 0.1M);
                Console.WriteLine("{0:f2}", sum3);
            }            
        }
    }
}