using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintGrade(double.Parse(Console.ReadLine()));
        }

        static void PrintGrade(double grade)
        {
            string gradeInWord = string.Empty;

            if (grade >= 2.00 && grade < 3.00)
            {
                gradeInWord = "Fail";
            }
            else if (grade >= 3.00 && grade < 3.50)
            {
                gradeInWord = "Poor";
            }
            else if (grade >= 3.50 && grade < 4.50)
            {
                gradeInWord = "Good";
            }
            else if (grade >= 4.50 && grade < 5.50)
            {
                gradeInWord = "Very good";
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                gradeInWord = "Excellent";
            }

            Console.WriteLine(gradeInWord);
        }

    }
}
