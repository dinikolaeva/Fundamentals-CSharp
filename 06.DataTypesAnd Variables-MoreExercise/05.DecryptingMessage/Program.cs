using System;

namespace _05.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            int numberOfLines = int.Parse(Console.ReadLine());

            int currentChar = 0;
            string message = string.Empty;

            for (int i = 0; i < numberOfLines; i++)
            {
                char inputLetter = char.Parse(Console.ReadLine());

                currentChar = inputLetter + key;

                message += (char)currentChar;
            }

            Console.WriteLine(message);
        }
    }
}
