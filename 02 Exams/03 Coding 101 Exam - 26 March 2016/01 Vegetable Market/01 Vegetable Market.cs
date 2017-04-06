using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            decimal d = decimal.Parse(Console.ReadLine());

            Console.WriteLine(((a*c) + (b*d))/1.94M);
        }
    }
}
