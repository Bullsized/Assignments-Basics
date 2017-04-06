using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Umnata_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceLaundry = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            var moneyAge = 0;
            var trueMoney = 0;
            var toyMoney = 0;
            var bonus = 10;

            if (age % 2 == 0)
            {
                moneyAge = age / 2;
                for (int i = 0; i < moneyAge; i++)
                {
                    trueMoney = trueMoney + bonus;
                    toyMoney = toyMoney + toyPrice;
                    bonus = bonus + 10;
                }

                var TTL = trueMoney + toyMoney - moneyAge;
                if (priceLaundry <= TTL)
                {
                    Console.WriteLine("Yes! {0:F2}", (TTL - priceLaundry));
                }
                else
                {
                    Console.WriteLine("No! {0:F2}", (priceLaundry - TTL));
                }
            }
            else
            {
                moneyAge = (int)(age / 2);
                for (int i = 0; i < moneyAge; i++)
                {
                    trueMoney = trueMoney + bonus;
                    bonus = bonus + 10;
                }
                for (int i = 0; i < moneyAge + 1; i++)
                {
                    toyMoney = toyMoney + toyPrice;
                }
                var TTL = trueMoney + toyMoney - moneyAge;
                if (priceLaundry <= TTL)
                {
                    Console.WriteLine("Yes! {0:F2}", TTL - priceLaundry);
                }
                else
                {
                    Console.WriteLine("No! {0:F2}",priceLaundry - TTL);
                }
            }
        }
    }
}