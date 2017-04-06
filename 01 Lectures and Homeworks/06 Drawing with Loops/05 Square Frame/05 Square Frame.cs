using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string plus = "+";
            string dash = "-";
            string space = " ";
            string line = "|";

            for (int top = 0; top < 1; top++)
            {
                Console.Write(plus);
                for (int middle = 0; middle < n - 2; middle++)
                {
                    Console.Write($"{space}{dash}");
                }
                Console.WriteLine($"{space}{plus}");
            }

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(line);
                for (int middle = 0; middle < n - 2; middle++)
                {
                    Console.Write($"{space}{dash}");
                }
                Console.WriteLine($"{space}{line}");
            }
            for (int top = 0; top < 1; top++)
            {
                Console.Write(plus);
                for (int middle = 0; middle < n - 2; middle++)
                {
                    Console.Write($"{space}{dash}");
                }
                Console.WriteLine($"{space}{plus}");


            }
        }
    }
}