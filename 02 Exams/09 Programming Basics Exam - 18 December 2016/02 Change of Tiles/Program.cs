using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Change_of_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal edno = decimal.Parse(Console.ReadLine());       //Ред 1.Събраните пари
            decimal dve = decimal.Parse(Console.ReadLine());         //Ред 2.Широчината на пода
            decimal tri = decimal.Parse(Console.ReadLine());         //Ред 3.Дължината на пода
            decimal chetri = decimal.Parse(Console.ReadLine());      //Ред 4.Страната на триъгълника
            decimal pet = decimal.Parse(Console.ReadLine());         //Ред 5.Височината на триъгълника
            decimal shest = decimal.Parse(Console.ReadLine());       //Ред 6.Цената на една плочка
            decimal sedem = decimal.Parse(Console.ReadLine());       //Ред 7.Сумата за майстора

            decimal ploshtaNaPoda = dve * tri;
            decimal ploshtaNaPlochka = (chetri * pet) / 2;
            decimal neobhodimiPlochki = ploshtaNaPoda / ploshtaNaPlochka;
            decimal neobhPlochki = Math.Ceiling(neobhodimiPlochki) + 5;
            decimal obshtaSuma = (neobhPlochki * shest) + sedem;

            if (obshtaSuma > edno)
            {
                decimal krai = obshtaSuma - edno;
                Console.WriteLine("You'll need {0:f2} lv more.", krai);
            }
            else if (obshtaSuma <= edno)
            {
                decimal krai = edno - obshtaSuma;
                Console.WriteLine("{0:f2} lv left.", krai);
            }
        }
    }
}