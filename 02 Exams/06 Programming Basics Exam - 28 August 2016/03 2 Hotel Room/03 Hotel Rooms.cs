using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Hotel_Rooms
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            decimal nights = decimal.Parse(Console.ReadLine());

            if (month == "may" || month == "october")
            {
                if (nights > 14)
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", (nights * 65M - (0.1M * (nights * 65M))));
                    Console.WriteLine("Studio: {0:f2} lv.", (nights * 50M - (0.3M * (nights * 50M))));
                }
                else if (nights > 7 && nights <= 14)
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", (nights * 65M));
                    Console.WriteLine("Studio: {0:f2} lv.", (nights * 50M - (0.05M * (nights * 50M))));
                }
                else
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", (nights * 65M));
                    Console.WriteLine("Studio: {0:f2} lv.", (nights * 50M));
                }
            }

            else if (month == "june" || month == "september")
            {
                if (nights > 14)
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", (nights * 68.7M - (0.1M * (nights * 68.7M))));
                    Console.WriteLine("Studio: {0:f2} lv.", (nights * 75.2M - (0.2M * (nights * 75.2M))));
                }
                else
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", (nights * 68.7M));
                    Console.WriteLine("Studio: {0:f2} lv.", (nights * 75.2M));
                }
            }

            else if (month == "july" || month == "august")
            {
                if (nights > 14)
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", (nights * 77M - (0.1M * (nights * 77M))));
                    Console.WriteLine("Studio: {0:f2} lv.", (nights * 76M));
                }
                else
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", (nights * 77M));
                    Console.WriteLine("Studio: {0:f2} lv.", (nights * 76M));
                }
            }           
        }
    }
}