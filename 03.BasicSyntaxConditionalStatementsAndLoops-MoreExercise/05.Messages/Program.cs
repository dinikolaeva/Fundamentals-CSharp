using System;

namespace _5.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int symbolsCount = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < symbolsCount; i++)
            {
                string inputNumber = Console.ReadLine();
                int numberOfDigits = inputNumber.Length;
                int mainDigit = inputNumber[0] - '0';
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 0)
                {
                    message += ' ';
                    continue;
                }
                else if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }

                    int letterIndex = offset + numberOfDigits - 1;
                    char letter = (char)(97 + letterIndex);

                message += letter;
            }

            Console.WriteLine(message);
        }
    }
}
