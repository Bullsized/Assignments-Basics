using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_1000_days
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която въвежда рождена дата във формат “dd-MM-yyyy” и 
            // пресмята датата, на която се навършват 1000 дни от тази рождена дата и я отпечатва в същия формат.

            var date = Console.ReadLine();
            string format = "dd-MM-yyyy";

            var result = DateTime.ParseExact(date, format, null);
            result = result.AddDays(999);

            var day = result.Day.ToString("00");
            var month = result.Month.ToString("00");
            var year = result.Year;

            Console.WriteLine("{0}-{1}-{2}", day, month, year);
        }
    }
}
