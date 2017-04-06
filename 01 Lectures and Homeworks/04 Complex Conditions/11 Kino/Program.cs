using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Kino
{
    class Program
    {
        static void Main(string[] args)
        {
            /* В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони. Има три вида прожекции с билети на различни цени:
•	Premiere – премиерна прожекция, на цена 12.00 лева.
•	Normal – стандартна прожекция, на цена 7.50 лева.
•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
Напишете програма, която въвежда тип прожекция (стринг), брой редове и брой колони в залата (цели числа) 
и изчислява общите приходи от билети при пълна зала. Резултатът да се отпечата във формат като в примерите по-долу, с 2 знака след десетичната точка.  
*/

            var type = Console.ReadLine().ToLower();
            var r = double.Parse(Console.ReadLine()); // redove
            var c = double.Parse(Console.ReadLine()); // koloni

            var x = r * c * 12; //prem
            var y = r * c * 7.5; //norm
            var z = r * c * 5; //discount
            
            switch (type)
            {
                case "premiere": Console.WriteLine($"{x:f2}"); break;
                case "normal": Console.WriteLine($"{y:f2}"); break;
                case "discount": Console.WriteLine($"{z:f2}"); break;
                default: Console.WriteLine("error"); break;
            }
        }
    }
}
