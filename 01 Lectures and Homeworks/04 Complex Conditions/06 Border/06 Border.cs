using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която проверява дали точка { x, y}
            //се намира върху някоя от страните на правоъгълник { x1, y1} – { x2, y2}. Входните данни се четат от конзолата и се състоят от 6 реда:
            //десетичните числа x1, y1, x2, y2, x и y(като се гарантира, че x1 < x2 и y1 < y2).Да се отпечата “Border” 
            //(точката лежи на някоя от страните) или “Inside / Outside” (в противен случай). Примери:

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if ((x == x1 || x == x2) && (y <= y2 && y >= y1) || (y == y1 || y == y2) && (x >= x1 && x <=x2))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
