using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            //            Магазин за плодове през работните дни работи на следните цени:
            //плод banana  apple orange  grapefruit kiwi    pineapple grapes
            //цена    2.50    1.20    0.85    1.45    2.70    5.50    3.85
            //Събота и неделя магазинът работи на по - високи цени:
            //  плод banana  apple orange  grapefruit kiwi    pineapple grapes
            //цена    2.70    1.25    0.90    1.60    3.00    5.60    4.20
            //Напишете програма, която чете от конзолата плод (banana / apple / orange / grapefruit / kiwi / pineapple / grapes), 
            //            ден от седмицата(Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) 
            //            и количество(десетично число) и пресмята цената според цените от таблиците по - горе.
            //            Резултатът да се отпечата закръглен с 2 цифри след десетичната точка.При невалиден ден от седмицата или 
            //            невалидно име на плод да се отпечата “error”. 

            var plod = Console.ReadLine().ToLower();
            var den = Console.ReadLine().ToLower();
            double x = double.Parse(Console.ReadLine());

            if (x >= 0)
            {
                if (den == "monday" || den == "tuesday" || den == "wednesday" || den == "thursday" || den == "friday")
                {
                    if (plod == "banana")
                    {
                        Console.WriteLine($"{x * 2.5:f2}");
                    }
                    else if (plod == "apple")
                    {
                        Console.WriteLine($"{x * 1.2:f2}");
                    }
                    else if (plod == "orange")
                    {
                        Console.WriteLine($"{x * 0.85:f2}");
                    }
                    else if (plod == "grapefruit")
                    {
                        Console.WriteLine($"{x * 1.45:f2}");
                    }
                    else if (plod == "kiwi")
                    {
                        Console.WriteLine($"{x * 2.7:f2}");
                    }
                    else if (plod == "pineapple")
                    {
                        Console.WriteLine($"{x * 5.5:f2}");
                    }
                    else if (plod == "grapes")
                    {
                        Console.WriteLine($"{x * 3.85:f2}");
                    }
                }
                else if (den == "saturday" || den == "sunday")
                {
                    if (plod == "banana")
                    {
                        Console.WriteLine($"{x * 2.7:f2}");
                    }
                    else if (plod == "apple")
                    {
                        Console.WriteLine($"{x * 1.25:f2}");
                    }
                    else if (plod == "orange")
                    {
                        Console.WriteLine($"{x * 0.9:f2}");
                    }
                    else if (plod == "grapefruit")
                    {
                        Console.WriteLine($"{x * 1.6:f2}");
                    }
                    else if (plod == "kiwi")
                    {
                        Console.WriteLine($"{x * 3:f2}");
                    }
                    else if (plod == "pineapple")
                    {
                        Console.WriteLine($"{x * 5.6:f2}");
                    }
                    else if (plod == "grapes")
                    {
                        Console.WriteLine($"{x * 4.2:f2}");
                    }
                }

            }
            if (den != "monday" || den != "tuesday" || den != "wednesday" || den != "thursday" || den != "friday"
    || den != "saturday" || den != "sunday" || plod != "banana" || plod != "apple" || plod != "orange"
    || plod != "grapefruit" || plod != "kiwi" || plod != "pineapple" || plod != "grapes")
            {
                Console.WriteLine("error");
            }
        }
    }
}
