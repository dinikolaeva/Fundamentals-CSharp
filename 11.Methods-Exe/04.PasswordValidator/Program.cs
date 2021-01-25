using System;
using System.Linq;

namespace E4.PasswordValidator
{
    class Program
    {

        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            IsValidPassword(password);
        }

        private static bool IsValidPassword(string password)
        {
            bool invalidPassword = false;

            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalidPassword = true;
            }

            if (!CheckPasswordHasOnlyDigitsAndLetters(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                invalidPassword = true;
            }

            if (CheckHasMoreThanTwoDigits(password) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalidPassword = true;
            }

            if (!invalidPassword)
            {
                Console.WriteLine("Password is valid");
            }
            return true;

        }

        static bool CheckPasswordHasOnlyDigitsAndLetters(string password)
        {

            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];

                if (!((currentChar >= 48 && currentChar <= 57)
                    || (currentChar >= 65 && currentChar <= 90)
                    || (currentChar >= 97 && currentChar <= 122)))
                {
                    return false;
                }
            }
            return true;
        }

        static int CheckHasMoreThanTwoDigits(string password)
        {
            int digitsCounter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];

                if (currentChar >= 48 && currentChar <= 57)
                {
                    digitsCounter++;
                }
            }
            return digitsCounter;
        }
    }
}
