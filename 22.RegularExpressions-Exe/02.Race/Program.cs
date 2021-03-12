using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var input = Console.ReadLine();

            Dictionary<string, int> runners = new Dictionary<string, int>();

            string namePattern = @"[a-zA-Z]";
            string digitsPattern = @"[0-9]";

            while (input != "end of race")
            {
                var foundNames = Regex.Matches(input, namePattern);
                var foundDigits = Regex.Matches(input, digitsPattern);

                var currentName = string.Empty;
                int currentTime = 0;

                foreach (var currentChar in foundNames)
                {
                    currentName += currentChar;
                }

                foreach (var currDigit in foundDigits)
                {
                    currentTime += int.Parse(currDigit.ToString());
                }

                if (names.Contains(currentName))
                {
                    if (!runners.ContainsKey(currentName))
                    {
                        runners.Add(currentName, currentTime);
                    }
                    else
                    {
                        runners[currentName] += currentTime;
                    }
                }

                input = Console.ReadLine();
            }

            int count = 1;

            foreach (var runner in runners
                .OrderByDescending(n => n.Value)
                .Take(3))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";

                Console.WriteLine($"{count}{text} place: {runner.Key}");

                count++;
            }

        }
    }
}
