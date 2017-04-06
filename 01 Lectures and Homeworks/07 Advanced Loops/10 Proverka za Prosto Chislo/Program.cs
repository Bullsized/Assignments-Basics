using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Proverka_za_Prosto_Chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            bool lamp = false;

            if (a < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        lamp = true;
                        Console.WriteLine("Not Prime");
                        break;
                    }
                }
                if (lamp == false)
                {
                    Console.WriteLine("Prime");
                }
            }
        }
    }
}