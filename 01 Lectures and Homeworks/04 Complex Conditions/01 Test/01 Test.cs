using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Първата задача от тази тема е да се напише конзолна програма, 
            //            която въвежда възраст(десетично число) и пол (“m” или “f”) и отпечатва обръщение измежду следните:
            //•	“Mr.” – мъж(пол “m”) на 16 или повече години
            //•	“Master” – момче(пол “m”) под 16 години
            //•	“Ms.” – жена(пол “f”) на 16 или повече години
            //•	“Miss” – момиче(пол “f”) под 16 години

            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine().ToLower();

            if (age >= 16)
            {
                if (gender == "m")
                {
                    Console.WriteLine("Mr.");
                }
                else if (gender == "f")
                {
                    Console.WriteLine("Ms.");
                }
            }
            else if (age < 16)
            {
                if (gender == "m")
                {
                    Console.WriteLine("Master");
                }
                else if (gender == "f")
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                Console.WriteLine("wrong input!");
            }
            
        }
    }
}
