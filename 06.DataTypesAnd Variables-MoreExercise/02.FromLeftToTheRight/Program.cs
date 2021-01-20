using System;
using System.Runtime.CompilerServices;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber; i++)
            {
                string twoNumbers = Console.ReadLine();
                string leftNum = string.Empty;
                string rightNum = string.Empty;

                bool isleftNumFound = false;

                for (int j = 0; j < twoNumbers.Length; j++)
                {
                    char space = twoNumbers[j];

                    if (isleftNumFound == false)
                    {
                        if (space == ' ')
                        {
                            isleftNumFound = true;
                        }
                        else
                        {
                            leftNum += twoNumbers[j];
                        }
                    }
                    else
                    {
                        rightNum += space;
                    }
                }

                long leftNumber = long.Parse(leftNum);
                long rightNumber = long.Parse(rightNum);

                long digitLeft = 0;
                long sumOfLeftDigits = 0;
                long digitRight = 0;
                long sumOfRightDigits = 0;

                if (leftNumber > rightNumber)
                {
                    leftNumber = Math.Abs(leftNumber);
                    while (leftNumber > 0)
                    {
                        digitLeft = leftNumber % 10;
                        leftNumber = leftNumber / 10;
                        sumOfLeftDigits += digitLeft;
                    }

                    Console.WriteLine(sumOfLeftDigits);
                }
                else
                {
                    rightNumber = Math.Abs(rightNumber);
                    while (rightNumber > 0)
                    {
                        digitRight = rightNumber % 10;
                        rightNumber = rightNumber / 10;
                        sumOfRightDigits += digitRight;
                    }

                    Console.WriteLine(sumOfRightDigits);
                }
            }
        }
    }
}
