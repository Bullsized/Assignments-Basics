using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Faktoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = 1;

            for (int i = n; i > 0; i--)
            {
                m = m * i;
            }
            Console.WriteLine(m);
        }
    }
}