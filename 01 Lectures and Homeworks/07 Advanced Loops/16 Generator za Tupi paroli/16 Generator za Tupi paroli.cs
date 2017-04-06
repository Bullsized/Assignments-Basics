using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Generator_za_Tupi_paroli
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int d1 = 1; d1 <= n - 1; d1++)
            {
                for (int d2 = 1; d2 <= n - 1; d2++)
                {
                    for (int d3 = 97; d3 < 97 + l; d3++)
                    {
                        for (int d4 = 97; d4 < 97 + l; d4++)
                        {
                            for (int d5 = 2; d5 <= n; d5++)
                            {
                                if (d5 > d2 && d5 > d1)
                                {
                                    Console.Write($"{d1}{d2}{(char)d3}{(char)d4}{d5} ");
                                }
                            }
                        }
                    }
                }
            }
            
        }
    }
}