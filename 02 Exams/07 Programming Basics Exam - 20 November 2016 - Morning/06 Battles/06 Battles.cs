using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int stopper = 0;

            for (int EDNO = 1; EDNO <= x; EDNO++)
            {
                for (int DVE = 1; DVE <= y; DVE++)
                {
                    if (stopper == z)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("({0} <-> {1}) ", EDNO, DVE);
                        stopper++;
                    }
                }
                if (stopper == z)
                {
                    break;
                }
            }
        }
    }
}