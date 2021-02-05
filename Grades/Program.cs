using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Grades(double.Parse(Console.ReadLine()));
        }


        static void Grades(double grade)
        {
            string gradeInWords = String.Empty;

            if (grade>=2 &&grade<=2.99)
            {
                gradeInWords = "Fail";
            }

            else if (grade>=3 && grade<=3.49)
            {
                gradeInWords = "Poor";
            }

            else if (grade >= 3.5 && grade <= 4.49)
            {
                gradeInWords = "Good";
            }

            else if (grade >= 4.5 && grade <= 5.49)
            {
                gradeInWords = "Very good";
            }

            else if (grade >= 5.5 && grade <= 6.00)
            {
                gradeInWords = "Excellent";
            }

            Console.WriteLine(gradeInWords);

        }
    }
}
