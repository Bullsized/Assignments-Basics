using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Nai_Golqm_Obsht_Delitel
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            Console.WriteLine(a);
        }
    }
}