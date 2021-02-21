using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> studentsResults = new Dictionary<string, List<string>>();

            while (input != "exam finished")
            {
                string[] infoOfExam = input
                    .Split('-')
                    .ToArray();

                string studentName = infoOfExam[0];
                string language = infoOfExam[1];
                int points = int.Parse(infoOfExam[2]);

                if (!studentsResults.ContainsKey(studentName))
                {
                    studentsResults.Add(studentName, new List<string>());
                    studentsResults[studentName].Add(language);
                }

                if (infoOfExam.Contains("banned"))
                {
                    studentsResults.Remove(studentName);
                }

                input = Console.ReadLine();
            }
        }
    }
}
