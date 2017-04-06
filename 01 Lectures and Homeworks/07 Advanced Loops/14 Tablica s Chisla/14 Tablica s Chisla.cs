using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Tablica_s_Chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int g = 0; g < n; g++)
                {
                    if ((i + g + 1) <= n)
                    {
                        Console.Write((i + g + 1) + " ");
                        
                    }
                    else
                    {
                        Console.Write(((2 * n) - (i + g + 1)) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}