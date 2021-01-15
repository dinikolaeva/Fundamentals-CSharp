using System;

namespace _01.StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfStudent = Console.ReadLine();
            int ageOfStudent = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {nameOfStudent}, Age: {ageOfStudent}, Grade: {averageGrade:f2}");
        }
    }
}
