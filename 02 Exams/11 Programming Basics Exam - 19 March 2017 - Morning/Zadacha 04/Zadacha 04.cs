using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_04
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lectures = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal money = budget / lectures;

            int Jelev = 0;
            int RoYaL = 0;
            int Roli = 0;
            int Trofon = 0;
            int Sino = 0;
            int Guest = 0;

            for (int cycle = 0; cycle < lectures; cycle++)
            {
                string person = Console.ReadLine();

                if (person == "Jelev")
                {
                    Jelev++;
                }
                else if (person == "RoYaL")
                {
                    RoYaL++;
                }
                else if (person == "Roli")
                {
                    Roli++;
                }
                else if (person == "Trofon")
                {
                    Trofon++;
                }
                else if (person == "Sino")
                {
                    Sino++;
                }
                else 
                {
                    Guest++;
                }
            }

            Console.WriteLine("Jelev salary: {0:f2} lv", Jelev * money);
            Console.WriteLine("RoYaL salary: {0:f2} lv", RoYaL * money);
            Console.WriteLine("Roli salary: {0:f2} lv", Roli * money);
            Console.WriteLine("Trofon salary: {0:f2} lv", Trofon * money);
            Console.WriteLine("Sino salary: {0:f2} lv", Sino * money);
            Console.WriteLine("Others salary: {0:f2} lv", Guest * money);

        }
    }
}
