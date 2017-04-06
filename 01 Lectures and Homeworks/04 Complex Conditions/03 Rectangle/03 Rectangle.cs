using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която проверява дали точка { x, y}
            //се намира вътре в правоъгълник { x1, y1} – { x2, y2}. Входните данни се четат от конзолата и се състоят от 6 реда:
            //десетичните числа x1, y1, x2, y2, x и y(като се гарантира, че x1 < x2 и y1 < y2).Една точка е вътрешна за даден правоъгълник, 
            //    ако се намира някъде във вътрешността му или 
            //    върху някоя от страните му. Отпечатайте “Inside” или “Outside”. Примери:

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

      //      var x3 = x2 - x1;
       //     var y3 = y2 - y1;

            if (x <= x2 && x1 <= x && y >= y1 && y <= y2)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
