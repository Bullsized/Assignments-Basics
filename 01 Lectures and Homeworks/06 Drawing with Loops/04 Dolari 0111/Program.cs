using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Dolari_0111
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int g = 0; g < i; g++)
                {
                    Console.Write(new string('$', 1));
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}