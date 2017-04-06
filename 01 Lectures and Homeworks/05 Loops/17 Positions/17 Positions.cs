using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            int whod = int.Parse(Console.ReadLine());

            var oddSum = 0d; 
            var evenSum = 0d;

            var oddMax = double.MinValue;
            var evenMax = double.MinValue;

            var oddMin = double.MaxValue;
            var evenMin = double.MaxValue;

            if (whod < 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                for (int i = 0; i < whod; i++)
                {
                    double zadadeno = double.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        oddSum = oddSum + zadadeno;
                        if (oddMin > zadadeno)
                        {
                            oddMin = zadadeno;
                        }

                        if (oddMax < zadadeno)
                        {
                            oddMax = zadadeno;
                        }
                    }
                    
                    else
                    {
                        evenSum = evenSum + zadadeno;
                        if (evenMin > zadadeno)
                        {
                            evenMin = zadadeno;
                        }

                        if (evenMax < zadadeno)
                        {
                            evenMax = zadadeno;
                        }
                    }
                   
                }
                Console.WriteLine("OddSum={0},", oddSum);

                if (oddMax == double.MinValue && oddMin == double.MaxValue)
                {
                    Console.WriteLine("OddMin=No,");
                    Console.WriteLine("OddMax=No,");
                }
                else
                {
                    Console.WriteLine("OddMin={0},", oddMin);
                    Console.WriteLine("OddMax={0},", oddMax);
                }

                Console.WriteLine("EvenSum={0},", evenSum);
                if (evenMax == double.MinValue && evenMin == double.MaxValue)
                {
                    Console.WriteLine("EvenMin=No,");
                    Console.WriteLine("EvenMax=No");
                }
                else
                {
                    Console.WriteLine("EvenMin={0},", evenMin);
                    Console.WriteLine("EvenMax=" + evenMax);
                }
            }
        }
    }
}