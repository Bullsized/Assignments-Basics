using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            int nad5 = 0;
            int ot4do5 = 0;
            int ot3do4 = 0;
            int pod3 = 0;

            var sumGrades = 0M;

            for (int i = 1; i <= students; i++)
            {
                decimal grades = decimal.Parse(Console.ReadLine());
                if (grades >= 5.00M)
                {
                    nad5++;
                }
                else if (4.00M <= grades && grades <= 4.99M)
                {
                    ot4do5++;
                }
                else if (3.00M <= grades && grades <= 3.99M)
                {
                    ot3do4++;
                }
                else if (3.00M > grades)
                {
                    pod3++;
                }
                sumGrades += grades;
            }
            
            double procenti = 100 / (double)students;
           // double procenti = Math.Floor(procent);
            Console.WriteLine("Top students: {0:f2}%", nad5*procenti);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", ot4do5 * procenti);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", ot3do4 * procenti);
            Console.WriteLine("Fail: {0:f2}%", pod3 * procenti);
            Console.WriteLine("Average: {0:f2}", sumGrades / students);

        }
    }
}
