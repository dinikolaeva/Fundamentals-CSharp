using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double gradeOfStudent = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                }
                students[studentName].Add(gradeOfStudent);
                
            }

            foreach (var student in students.OrderByDescending(x=>x.Value.Average()))
            {
                double averageGrade = student.Value.Average();

                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:f2}");
                }
            }         
        }
    }
}
