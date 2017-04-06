using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arrH = int.Parse(Console.ReadLine());
            int arrM = int.Parse(Console.ReadLine());

            int timeExam = examH * 60 + examM;
            int timeArr = arrH * 60 + arrM;

            int early = timeExam - timeArr;
            int late = timeArr - timeExam;

            if (timeArr == timeExam)
            {
                Console.WriteLine("On time");
            }
            else if (early <= 30 && early > 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", early);
            }

            else if (early > 30)
            {
                Console.WriteLine("Early");
                if (early <= 59)
                {
                    Console.WriteLine("{0} minutes before the start", early);
                }
                else
                {
                    int hours = early / 60;
                    int mins = early - (hours * 60);
                    if (mins < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours before the start", hours, mins);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours before the start", hours, mins);
                    }
                }
            }


            else if (timeArr > timeExam)
            {
                Console.WriteLine("Late");
                if (late <= 59)
                {
                    Console.WriteLine("{0} minutes after the start", late);
                }
                else
                {
                    int hours = late / 60;
                    int mins = late - (hours * 60);
                    if (mins < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours after the start", hours, mins);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours after the start", hours, mins);
                    }
                }
            }
        }
    }
}