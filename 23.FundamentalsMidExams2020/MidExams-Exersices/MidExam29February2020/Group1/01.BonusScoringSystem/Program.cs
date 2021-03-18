using System;

namespace _01.BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            byte countOfStudents = byte.Parse(Console.ReadLine());
            byte countOfLectures = byte.Parse(Console.ReadLine());
            byte initialBonus = byte.Parse(Console.ReadLine());

            double totalBonus = 0;
            int bestStudentBonusAttendences = 0;

            for (int i = 0; i < countOfStudents; i++)
            {
                int attendances = int.Parse(Console.ReadLine());

                double bonusForStudent = attendances * 1.0 / countOfLectures * (5 + initialBonus);

                if (bonusForStudent > totalBonus)
                {
                    totalBonus = bonusForStudent;
                    bestStudentBonusAttendences = attendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(totalBonus)}.");
            Console.WriteLine($"The student has attended {bestStudentBonusAttendences} lectures.");
        }
    }
}
