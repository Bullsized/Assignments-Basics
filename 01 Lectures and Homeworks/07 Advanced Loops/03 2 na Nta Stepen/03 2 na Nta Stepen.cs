using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_2_na_Nta_Stepen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(d);
                d = d * 2;
            }

            //   Console.WriteLine(Math.Pow(2, i));
        }
    }
}