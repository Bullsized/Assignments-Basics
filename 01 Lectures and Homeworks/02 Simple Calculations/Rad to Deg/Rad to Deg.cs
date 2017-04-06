using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad_to_Deg
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Напишете програма, която чете ъгъл в радиани (rad)и го преобразува в градуси(deg).Потърсете в Интернет подходяща формула.
            //      Числото π в C# програми е достъпно чрез Math.PI. 
            //       Закръглете резултата до най-близкото цяло число използвайки Math.Round(). Примери:
            // Degrees = Radians∗180 / π

            double rad = double.Parse(Console.ReadLine());
            double deg = ((rad * 180) / Math.PI);
            Console.WriteLine(Math.Round(deg, 0));
        }
    }
}
