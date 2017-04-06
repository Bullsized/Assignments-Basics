using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Last
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Дадени са 2 * n числа.Първото и второто формират двойка, третото и четвъртото също и т.н.Всяка двойка има стойност – 
                  сумата от съставящите я числа.Напишете програма, която проверява дали всички двойки имат еднаква стойност или 
                  печата максималната разлика между две последователни двойки.Ако всички двойки имат еднаква стойност, отпечатайте 
                  "Yes, value=…" + стойността.В противен случай отпечатайте "No, maxdiff=…" + максималната разлика. */

            int entryDigit = int.Parse(Console.ReadLine());

            var firstCouple = 0d; 
            var secondCouple = 0d; 
            var thirdCouple = 0d; 
            var fourthCouple = 0d;



        }
    }
}
            /*for (int i = 0; i < entryDigit; i++)
            {
                double firstGain = double.Parse(Console.ReadLine());
                firstCouple = firstCouple + firstGain;
            }
            for (int i = 0; i < entryDigit; i++)
            {
                double secondGain = double.Parse(Console.ReadLine());
                secondCouple = secondCouple + secondGain;
            }
            for (int i = 0; i < entryDigit; i++)
            {
                double thirdGain = double.Parse(Console.ReadLine());
                thirdCouple = thirdCouple + thirdGain;
            }
            for (int i = 0; i < entryDigit; i++)
            {
                double fourthGain = double.Parse(Console.ReadLine());
                fourthCouple = fourthCouple + fourthGain; 
        }
            if (firstC == secondCouple) // && secondCouple == thirdCouple && thirdCouple == fourthCouple
            {
                Console.WriteLine("Yes, value = " + firstCouple);
            } */
