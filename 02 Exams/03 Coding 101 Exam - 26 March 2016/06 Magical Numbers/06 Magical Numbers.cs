using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Magical_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int a1 = 0; a1 <= 9; a1++)
            {
                for (int a2 = 0; a2 <= 9; a2++)
                {
                    for (int a3 = 0; a3 <=9; a3++)
                    {
                        for (int a4 = 0; a4 <=9; a4++)
                        {
                            for (int a5 = 0; a5 <=9 ; a5++)
                            {
                                for (int a6 = 0; a6 <=9 ; a6++)
                                {
                                    if (a1 * a2 * a3 * a4 * a5 * a6 == n)
                                    {
                                        Console.Write($"{a1}{a2}{a3}{a4}{a5}{a6} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}