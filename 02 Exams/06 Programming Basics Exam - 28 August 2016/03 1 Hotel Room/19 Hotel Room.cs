using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            int days = int.Parse(Console.ReadLine());

            var studioMay7 = (days * 50) - (days * 50 * 0.05);
            var studionad14May = days * 50 - (days * 50 * 0.3);
            var studioJune14 = (days * 75.2) - (days * 75.2 * 0.2);
            var apt1May = days * 65 - (days * 65 * 0.1);
            var apt2June = days * 68.7 - (days * 68.7 * 0.1);
            var apt3Aug = days * 77 - (days * 77 * 0.1);


            if (days < 0 || days > 200)
            {
                Console.WriteLine("wrong input");
            }

            if (month == "may" || month == "october")
            {
                if (days > 7 && days < 14)
                {
                    Console.WriteLine($"Apartment: {days * 65:f2} lv.");
                    Console.WriteLine($"Studio: {studioMay7:f2} lv.");
                }
                else if (days >= 14)
                {
                    Console.WriteLine($"Apartment: {apt1May:f2} lv.");
                   Console.WriteLine($"Studio: {studionad14May:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"Apartment: {days*65:f2} lv.");
                    Console.WriteLine($"Studio: {days*50:f2} lv.");
                }
            }
            else if (month == "june" || month == "september")
            {
                if (days > 14)
                {
                    Console.WriteLine($"Apartment: {apt2June:f2} lv.");
                    Console.WriteLine($"Studio: {studioJune14:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"Apartment: {days * 68.7:f2} lv.");
                    Console.WriteLine($"Studio: {days * 75.2:f2} lv.");
                }
            }
            else if (month == "july" || month == "august")
            {
                if (days > 14)
                {
                    Console.WriteLine($"Apartment: {apt3Aug:f2} lv.");
                    Console.WriteLine($"Studio: {days * 76:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"Apartment: {days * 77:f2} lv.");
                    Console.WriteLine($"Studio: {days * 76:f2} lv.");
                }
            }        
        }
    }
}
