using System;

namespace _2.EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int lastDigit = number % 10;
            string englishNameOfLastDigit = " ";

            switch (lastDigit)
            {
                case 1:
                    englishNameOfLastDigit = "one";
                    break;
                case 2:
                    englishNameOfLastDigit = "two";
                    break;
                case 3:
                    englishNameOfLastDigit = "three";
                    break;
                case 4:
                    englishNameOfLastDigit = "four";
                    break;
                case 5:
                    englishNameOfLastDigit = "five";
                    break;
                case 6:
                    englishNameOfLastDigit = "six";
                    break;
                case 7:
                    englishNameOfLastDigit = "seven";
                    break;
                case 8:
                    englishNameOfLastDigit = "eight";
                    break;
                case 9:
                    englishNameOfLastDigit = "nine";
                    break;
                default:
                    englishNameOfLastDigit = "zero";
                    break;
            }

            Console.WriteLine(englishNameOfLastDigit);
        }

    }
}
