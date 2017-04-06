using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal days = decimal.Parse(Console.ReadLine());
            decimal dollars = decimal.Parse(Console.ReadLine());
            decimal exchRate = decimal.Parse(Console.ReadLine());

            decimal perMonth = days * dollars;
            decimal yearlyBonus = perMonth * 2.5M;
            decimal answer = (12M*perMonth + yearlyBonus) - (0.25M * (12M*perMonth + yearlyBonus));
            decimal leva = answer * exchRate;

            Console.WriteLine("{0:f2}", (leva/365M));
        }
    }
}