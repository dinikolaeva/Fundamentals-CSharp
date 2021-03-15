using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _5.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesOfDemons = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            namesOfDemons.Sort();

            foreach (var demon in namesOfDemons)
            {

                string nameOfDemon = @"[^0-9\+\-\*\/\.]+";
                string baseDemage = @"-*([0-9]+\.)*[0-9]+";
                string mathSymbols = @"[\*]|[\/]";

                var matchLetter = Regex.Matches(demon, nameOfDemon);
                var matchDigits = Regex.Matches(demon, baseDemage);
                var matchSymbols = Regex.Matches(demon, mathSymbols);

                string currentName = string.Empty;

                foreach (Match currentChar in matchLetter)
                {
                    currentName += currentChar;
                }

                int demonTotalHelth = 0;

                if (currentName.Length >= 1)
                {

                    foreach (char letter in currentName)
                    {
                        demonTotalHelth += letter;
                    }
                }

                double currentBaseDemage = 0;

                foreach (Match digit in matchDigits)
                {
                    currentBaseDemage += double.Parse(digit.ToString());
                }

                foreach (Match symbol in matchSymbols)
                {
                    char symbolChar = char.Parse(symbol.ToString());

                    if (symbolChar == '*')
                    {
                        currentBaseDemage *= 2;
                    }
                    else
                    {
                        currentBaseDemage /= 2;
                    }
                }

                Console.WriteLine($"{demon} - {demonTotalHelth} health, {currentBaseDemage:f2} damage");
            }
        }
    }
}
