using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\+359([-| ])2(\1)([0-9]{3})(\1)([0-9]{4})\b";

            var phones = Console.ReadLine();

            var matches = Regex.Matches(phones,pattern);

            var machedPhoneNumbers = matches
                .Cast<Match>()
                .Select(n=>n.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ",machedPhoneNumbers));
        }
    }
}
