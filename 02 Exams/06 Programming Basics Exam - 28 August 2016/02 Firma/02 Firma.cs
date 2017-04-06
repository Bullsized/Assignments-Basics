using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal hours = decimal.Parse(Console.ReadLine());
            decimal days = decimal.Parse(Console.ReadLine());
            decimal employees = decimal.Parse(Console.ReadLine());

            decimal time = days - (days * 0.1M);
            decimal a = time * 8M;
            decimal b = employees * 2M * days;
            decimal c = Math.Truncate(a + b);

            if (c >= hours)
            {
                Console.WriteLine("Yes!{0} hours left.", c - hours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Abs(hours - c));
            }
        }
    }
}