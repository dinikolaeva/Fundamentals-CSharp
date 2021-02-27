using System;
using System.Linq;

namespace _1.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (string user in userNames)
            {
                bool isValid = IsValidUsername(user);

                if (isValid)
                {
                    Console.WriteLine(user);
                }
            }
        }

        private static bool IsValidUsername(string user)
        {

            return user.Length > 3 && user.Length < 16
                && user.All(x => char.IsLetterOrDigit(x)
                || user.Contains('-')
                || user.Contains('_'));
          
        }
    }
}
