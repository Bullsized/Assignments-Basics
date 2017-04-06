using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Piramida_ot_Chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int f = 0; f < i; f++)
                {
                    Console.Write($"{a} ");
                    a++;
                    if (a == (n + 1))
                    {
                        break;
                    }
                }
                
                Console.WriteLine();
                if (a == (n + 1))
                {
                    break;
                }
            }
        }
    }
}