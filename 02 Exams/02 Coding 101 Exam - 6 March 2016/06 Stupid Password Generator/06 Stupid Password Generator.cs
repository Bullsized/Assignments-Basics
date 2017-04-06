using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            char letter = 'a';

            switch (l)
            {
                case 1: letter = 'a'; break;
                case 2: letter = 'b'; break;
                case 3: letter = 'c'; break;
                case 4: letter = 'd'; break;
                case 5: letter = 'e'; break;
                case 6: letter = 'f'; break;
                case 7: letter = 'g'; break;
                case 8: letter = 'h'; break;
                case 9: letter = 'i'; break;
            }

            for (int d1 = 1; d1 <= n; d1++)
            {
                for (int d2 = 1; d2 <= n; d2++)
                {
                    for (char a1 = 'a'; a1 <= letter; a1++)
                    {
                        for (int a2 = 'a'; a2 <= letter; a2++)
                        {
                            for (int d5 = 1; d5 <= n; d5++)
                            {
                                if (d5 > d1 && d5 > d2)
                                {
                                    Console.Write($"{d1}{d2}{a1}{(char)a2}{d5} ");
                                }
                            }
                        }
                    }                   
                }
            }
        }
    }
}