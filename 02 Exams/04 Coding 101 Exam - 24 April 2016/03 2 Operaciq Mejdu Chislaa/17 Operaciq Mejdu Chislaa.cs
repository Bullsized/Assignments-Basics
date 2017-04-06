using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Operaciq_Mejdu_Chislaa
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            string opr = Console.ReadLine();

            if (opr == "+")
            {
                double sum = x + y;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{x} + {y} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{x} + {y} = {sum} - odd");
                }
            }
            else if (opr == "-")
            {
                double sum = x - y;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{x} - {y} = {sum} - even");
                }
                else if (sum % 2 != 0)
                {
                    Console.WriteLine($"{x} - {y} = {sum} - odd");
                }
            }
            else if (opr == "*")
            {
                double sum = x * y;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{x} * {y} = {sum} - even");
                }
                else if (sum % 2 != 0)
                {
                    Console.WriteLine($"{x} * {y} = {sum} - odd");
                }
            }
            else if (opr == "/")
            {
                if (y != 0)
                {
                    double sum = x / y;
                    Console.WriteLine($"{x} / {y} = {Math.Round(sum, 2)}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {x} by zero");
                }

            }
            else if (opr == "%")
            {
                if (y != 0)
                {
                    double sum = x % y;
                    Console.WriteLine($"{x} % {y} = {sum}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {x} by zero");
                }
            }
        }
    }
}