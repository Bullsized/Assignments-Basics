using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal junior = decimal.Parse(Console.ReadLine());
            decimal senior = decimal.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            decimal totalMoney = 0;

            if (type == "trail")
            {
                totalMoney = (junior * 5.50M) + (senior * 7M);
                decimal answer = totalMoney - (totalMoney * 0.05M);
                Console.WriteLine("{0:f2}", answer);
            }
            else if (type == "cross-country")
            {
                if (junior + senior >= 50)
                {
                    totalMoney = (junior * (8M - (8M * 0.25M))) + (senior * (9.50M - (9.50M * 0.25M)));
                    decimal answer = totalMoney - (totalMoney * 0.05M);
                    Console.WriteLine("{0:f2}", answer);
                }
                else
                {
                    totalMoney = (junior * 8M) + (senior * 9.50M);
                    decimal answer = totalMoney - (totalMoney * 0.05M);
                    Console.WriteLine("{0:f2}", answer);
                }
            }
            else if (type == "downhill")
            {
                totalMoney = (junior * 12.25M) + (senior * 13.75M);
                decimal answer = totalMoney - (totalMoney * 0.05M);
                Console.WriteLine("{0:f2}", answer);
            }
            else if (type == "road")
            {
                totalMoney = (junior * 20M) + (senior * 21.5M);
                decimal answer = totalMoney - (totalMoney * 0.05M);
                Console.WriteLine("{0:f2}", answer);
            }
        }
    }
}