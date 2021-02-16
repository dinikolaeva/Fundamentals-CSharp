using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (command != "end")
            {
                string[] currentCourse = command
                    .Split(" : ")
                    .ToArray();

                string courseName = currentCourse[0];
                string studentName = currentCourse[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(studentName);

                command = Console.ReadLine();
            }

            foreach (var course in courses.OrderByDescending(x=> x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
