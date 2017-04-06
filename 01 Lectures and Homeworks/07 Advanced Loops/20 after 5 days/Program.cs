using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_after_5_days
{
    class Program
    {
        static void Main(string[] args)
        {
            int date = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            string dateMonth = "" + date + "." + month;
            var newDate = DateTime.Parse(dateMonth);
            newDate = newDate.AddDays(5);
            Console.WriteLine($"{newDate:d.MM}");
            //  Console.WriteLine(newDate.ToString("d/MM"));
        }
    }
}
