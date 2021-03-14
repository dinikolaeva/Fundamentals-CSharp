using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _4.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            int attackCount = 0;
            int destroyedCount = 0;

            for (int i = 0; i < n; i++)
            {
                string encryptMessage = Console.ReadLine();

                string decryptionKey = @"[STAR]|[star]";

                var matchLetters = Regex.Matches(encryptMessage, decryptionKey);

                int count = 0;

                foreach (Match letter in matchLetters)
                {
                    count++;
                }

                string decryptMessage = string.Empty;

                for (int j = 0; j < encryptMessage.Length; j++)
                {
                    char letter = (char)(encryptMessage[j] - count);
                    decryptMessage += letter;
                }

                string pattern = @"@(?<planet>[A-z]+)[^@!\->:]*:(?<population>\d+)[^@!\->:]*!(?<attackType>[A]|[D]?)![^@!\->:]*->(?<soldiers>\d+)";

                var informationForPLanet = Regex.Matches(decryptMessage, pattern);

                foreach (Match planet in informationForPLanet)
                {
                    var planetName = planet.Groups["planet"].Value;
                    int population = int.Parse(planet.Groups["population"].Value);
                    char attackType = char.Parse(planet.Groups["attackType"].Value);
                    int soldiers = int.Parse(planet.Groups["soldiers"].Value);

                    if (attackType == 'A')
                    {
                        attackedPlanets.Add(planetName);
                        attackCount++;
                    }
                    else
                    {
                        destroyedPlanets.Add(planetName);
                        destroyedCount++;
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackCount}");

            if (attackCount > 0)
            {
                attackedPlanets.Sort();

                foreach (var item in attackedPlanets)
                {
                    Console.WriteLine($"-> {item}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedCount}");

            if (destroyedCount > 0)
            {
                destroyedPlanets.Sort();

                foreach (var item in destroyedPlanets)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
        }
    }
}
