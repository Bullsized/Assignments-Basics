using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celzii_kum_Farenhait
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която чете градуси по скалата на Целзий (°C) и ги преобразува до градуси по скалата на Фаренхайт(°F).
            //     Потърсете в Интернет подходяща формула, с която да извършите изчисленията. 
            //     Закръглете резултата до 2 знака след десетичната точка. 
            //     Multiply by 9, then divide by 5, then add 32

            decimal c = decimal.Parse(Console.ReadLine());
            decimal answer = (((c * 9) / 5 ) + 32);

            Console.WriteLine(Math.Round(answer, 2));
        }
    }
}
