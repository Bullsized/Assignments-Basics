using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Tupata_kotka_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int workDays = 365 - days;
            var realPlayTime = (workDays * 63) + (days * 127);

            if (30000 >= realPlayTime)
            {
                var leftTime = 30000 - realPlayTime;
                int lefthrs = leftTime / 60;
                int leftMins = leftTime % 60;
                Console.WriteLine("Tom sleeps well\n{0} hours and {1} minutes less for play", lefthrs, leftMins);
            }
            else if (30000 < realPlayTime)
            {
                var leftTime = realPlayTime - 30000;
                int lefthrs = leftTime / 60;
                int leftMins = leftTime % 60;
                Console.WriteLine("Tom will run away\n{0} hours and {1} minutes more for play", lefthrs, leftMins);
            }
        }
    }
}