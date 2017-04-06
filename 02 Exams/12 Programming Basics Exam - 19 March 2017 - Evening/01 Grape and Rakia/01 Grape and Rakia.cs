using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());

            decimal totalKG = a * b;
            decimal leftReal = totalKG - c;
            decimal outTurn1 = leftReal * 0.45M;
            decimal liters = outTurn1 / 7.5M;
            decimal income = liters * 9.8M;

            decimal outTurnKG = leftReal * 0.55M;
            decimal raki = outTurnKG * 1.5M;

            Console.WriteLine("{0:f2}", income);
            Console.WriteLine("{0:f2}", raki);
        }
    }
}