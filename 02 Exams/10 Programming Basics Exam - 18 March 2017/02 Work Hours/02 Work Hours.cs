using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Work_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int job = workers * days * 8;

            if (job >= hours)
            {
                Console.WriteLine(job - hours + " hours left");
            }
            else
            {
                int churka = Math.Abs(job - hours);
                Console.WriteLine(churka + " overtime");
                Console.WriteLine("Penalties: " + (churka * days));
            }
        }
    }
}