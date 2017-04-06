using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която преобразува разстояние между следните 8 мерни единици: 
            // m, mm, cm, mi, in, km, ft, yd. Използвайте съответствията от таблицата по-долу:
            //  входна единица  изходна единица
            // 1 meter(m) 1000 millimeters(mm)
            // 1 meter(m) 100 centimeters(cm)
            // 1 meter(m) 0.000621371192 miles(mi)
            // 1 meter(m) 39.3700787 inches(in)
            // 1 meter(m) 0.001 kilometers(km)
            // 1 meter(m) 3.2808399 feet(ft)
            // 1 meter(m) 1.0936133 yards(yd)

            float x = float.Parse(Console.ReadLine());
            string QW = Console.ReadLine();
            string AS = Console.ReadLine();

            if (QW == "m" && AS == "mm")
            {
                Console.WriteLine(x * 1000);
            }
            if (QW == "m" && AS == "m")
            {
                Console.WriteLine(x);
            }
            else if (QW == "m" && AS == "cm")
            {
                Console.WriteLine(x * 100);
            }
            else if (QW == "m" && AS == "mi")
            {
                Console.WriteLine(x * 0.000621371192);
            }
            else if (QW == "m" && AS == "in")
            {
                Console.WriteLine(x * 39.3700787);
            }
            else if (QW == "m" && AS == "km")
            {
                Console.WriteLine(x * 0.001);
            }
            else if (QW == "m" && AS == "ft")
            {
                Console.WriteLine(x * 3.2808399);
            }
            else if (QW == "m" && AS == "yd")
            {
                Console.WriteLine(x * 1.0936133);
            }
            else if (QW == "mm" && AS == "m")
            {
                Console.WriteLine(x / 1000);
            }
            else if (QW == "mm" && AS == "mm")
            {
                Console.WriteLine(x);
            }
            else if (QW == "mm" && AS == "cm")
            {
                Console.WriteLine(x * 0.1);
            }
            else if (QW == "mm" & AS == "mi")
            {
                Console.WriteLine(x * 0.000000621371192);
            }
            else if (QW == "mm" && AS == "in")
            {
                Console.WriteLine(x * 0.0393700787);
            }
            else if (QW == "mm" && AS == "km")
            {
                Console.WriteLine(x * 0.000001);
            }
            else if (QW == "mm" && AS == "ft")
            {
                Console.WriteLine(x * 0.0032808399);
            }
            else if (QW == "mm" && AS == "yd")
            {
                Console.WriteLine(x * 0.0010936133);
            }
            else if (QW == "cm" && AS == "cm")
            {
                Console.WriteLine(x);
            }
            else if (QW == "cm" && AS == "mm")
            {
                Console.WriteLine(x * 10);
            }
            else if (QW == "cm" && AS == "m")
            {
                Console.WriteLine(x / 100);
            }
            else if (QW == "cm" && AS == "mi")
            {
                Console.WriteLine(x * 0.00000621371192);
            }
            else if (QW == "cm" && AS == "in")
            {
                Console.WriteLine(x * 0.393700787);
            }
            else if (QW == "cm" && AS == "km")
            {
                Console.WriteLine(x * 0.00001);
            }
            else if (QW == "cm" && AS == "ft")
            {
                Console.WriteLine(x * 0.032808399);
            }
            else if (QW == "cm" && AS == "yd")
            {
                Console.WriteLine(x * 0.010936133);
            }
            else if (QW == "mi" && AS == "mi")
            {
                Console.WriteLine(x);
            }
            else if (QW == "mi" && AS == "mm")
            {
                Console.WriteLine(x * (1000 / 0.000621371192));
            }
            else if (QW == "mi" && AS == "cm")
            {
                Console.WriteLine(x * (100 / 0.000621371192));
            }
            else if (QW == "mi" && AS == "m")
            {
                Console.WriteLine(x / 0.000621371192);
            }
            else if (QW == "mi" && AS == "m")
            {
                Console.WriteLine(x / 0.000621371192);
            }
            else if (QW == "mi" && AS == "in")
            {
                Console.WriteLine(x * (39.3700787 / 0.000621371192));
            }
            else if (QW == "mi" && AS == "km")
            {
                Console.WriteLine(x * (0.001 / 0.000621371192));
            }
            else if (QW == "mi" && AS == "ft")
            {
                Console.WriteLine(x * (3.2808399 / 0.000621371192));
            }
            else if (QW == "mi" && AS == "yd")
            {
                Console.WriteLine(x * (1.0936133 / 0.000621371192));
            }
            else if (QW == "in" && AS == "in")
            {
                Console.WriteLine(x);
            }
            else if (QW == "in" && AS == "mm")
            {
                Console.WriteLine(x * (1000 / 39.3700787));
            }
            else if (QW == "in" && AS == "cm")
            {
                Console.WriteLine(x * (100 / 39.3700787));
            }
            else if (QW == "in" && AS == "m")
            {
                Console.WriteLine(x / 39.3700787);
            }
            else if (QW == "in" && AS == "mi")
            {
                Console.WriteLine(x * (0.000621371192 / 39.3700787));
            }
            else if (QW == "in" && AS == "km")
            {
                Console.WriteLine(x * (0.001 / 39.3700787));
            }
            else if (QW == "in" && AS == "ft")
            {
                Console.WriteLine(x * (3.2808399 / 39.3700787));
            }
            else if (QW == "in" && AS == "yd")
            {
                Console.WriteLine(x * (1.0936133 / 39.3700787));
            }
            else if (QW == "km" && AS == "km")
            {
                Console.WriteLine(x);
            }
            else if (QW == "km" && AS == "mm")
            {
                Console.WriteLine(x * (1000 / 0.001));
            }
            else if (QW == "km" && AS == "cm")
            {
                Console.WriteLine(x * (100 / 0.001));
            }
            else if (QW == "km" && AS == "m")
            {
                Console.WriteLine(x / 0.001);
            }
            else if (QW == "km" && AS == "mi")
            {
                Console.WriteLine(x * (0.000621371192 / 0.001));
            }
            else if (QW == "km" && AS == "in")
            {
                Console.WriteLine(x * (39.3700787 / 0.001));
            }
            else if (QW == "km" && AS == "ft")
            {
                Console.WriteLine(x * (3.2808399 / 0.001));
            }
            else if (QW == "km" && AS == "yd")
            {
                Console.WriteLine(x * (1.0936133 / 0.001));
            }
            else if (QW == "ft" && AS == "ft")
            {
                Console.WriteLine(x);
            }
            else if (QW == "ft" && AS == "mm")
            {
                Console.WriteLine(x * (1000 / 3.2808399));
            }
            else if (QW == "ft" && AS == "cm")
            {
                Console.WriteLine(x * (100 / 3.2808399));
            }
            else if (QW == "ft" && AS == "m")
            {
                Console.WriteLine(x / 3.2808399);
            }
            else if (QW == "ft" && AS == "mi")
            {
                Console.WriteLine(x * (0.000621371192 / 3.2808399));
            }
            else if (QW == "ft" && AS == "in")
            {
                Console.WriteLine(x * (39.3700787 / 3.2808399));
            }
            else if (QW == "ft" && AS == "km")
            {
                Console.WriteLine(x * (0.001 / 3.2808399));
            }
            else if (QW == "ft" && AS == "yd")
            {
                Console.WriteLine(x * (1.0936133 / 3.2808399));
            }
            else if (QW == "yd" && AS == "yd")
            {
                Console.WriteLine(x);
            }
            else if (QW == "yd" && AS == "mm")
            {
                Console.WriteLine(x * (1000 / 1.0936133));
            }
            else if (QW == "yd" && AS == "cm")
            {
                Console.WriteLine(x * (100 / 1.0936133));
            }
            else if (QW == "yd" && AS == "m")
            {
                Console.WriteLine(x / 1.0936133);
            }
            else if (QW == "yd" && AS == "mi")
            {
                Console.WriteLine(x * (0.000621371192 / 1.0936133));
            }
            else if (QW == "yd" && AS == "in")
            {
                Console.WriteLine(x * (39.3700787 / 1.0936133));
            }
            else if (QW == "yd" && AS == "km")
            {
                Console.WriteLine(x * (0.001 / 1.0936133));
            }
            else if (QW == "yd" && AS == "ft")
            {
                Console.WriteLine(x * (3.2808399 / 1.0936133));
            }
            else
            {
                Console.WriteLine("Wrong Imput!");
            }
        }
    }
}