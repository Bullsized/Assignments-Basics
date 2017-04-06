using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Ch_Tree_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string(' ', n));
            Console.WriteLine(" |");
         
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write(new string('*', i));
                Console.Write(" ");
                Console.Write("|");
                Console.Write(" ");
                Console.WriteLine(new string('*', i));
            }
            System.Threading.Thread.Sleep(1250);
        }
    }
}
