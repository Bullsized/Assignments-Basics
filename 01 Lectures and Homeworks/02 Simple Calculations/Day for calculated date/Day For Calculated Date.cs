using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_for_calculated_date
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(1992, 02, 05);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
