using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            var edno = 0;
            var dve = 0;
            var pregledani = 0;
            var nePregledani = 0;

            for (int i = 1; i <= period; i++)
            {
                edno = int.Parse(Console.ReadLine());

                while (i % 3 == 0)
                {
                    if (pregledani < nePregledani)
                    {
                        dve++;
                    }
                    break;
                }
                if (edno > 7)
                {
                    nePregledani = nePregledani + (edno - 7) - dve;
                    pregledani = pregledani + 7 + dve;
                }
                else
                {
                    if (edno < 7)
                    {
                        pregledani = pregledani + edno;
                    }
                    else
                    {
                        pregledani = pregledani + 7 + dve;
                    }
                }
            }
            Console.WriteLine("Treated patients: {0}.", pregledani);
            Console.WriteLine("Untreated patients: {0}.", nePregledani);
        }
    }
}