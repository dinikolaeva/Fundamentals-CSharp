using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            int countOfTry = 1;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];

            }

            string inputPassword = Console.ReadLine();

            while (inputPassword != password)
            {
                Console.WriteLine("Incorrect password. Try again.");

                countOfTry++;

                if (countOfTry == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                inputPassword = Console.ReadLine();
            }

            if (inputPassword == password && countOfTry < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
