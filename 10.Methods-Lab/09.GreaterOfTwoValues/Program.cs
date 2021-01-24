using System;
using System.Linq;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfValue = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            if (typeOfValue == "int")
            {
                int num1 = int.Parse(value1);
                int num2 = int.Parse(value2);
                int biggerInteger = GetMaxInt(num1, num2);
                Console.WriteLine(biggerInteger);
            }
            else if (typeOfValue == "char")
            {
                char char1 = char.Parse(value1);
                char char2 = char.Parse(value2);
                char biggerChar = GetMaxChar(char1, char2);
                Console.WriteLine(biggerChar);
            }
            else if (typeOfValue == "string")
            {
                string maxString = GetMaxString(value1, value2);
                Console.WriteLine(maxString);
            }

        }

        static string GetMaxString(string value1, string value2)
        {
            string maxString = string.Empty;

            if (value1.CompareTo(value2) >= 0)
            {
                maxString = value1;
                return maxString;
            }
            else
            {
                maxString = value2;
                return maxString;
            }

        }

        static int GetMaxInt(int num1, int num2)
        {

            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static char GetMaxChar(char char1, char char2)
        {
            if (char1 > char2)
            {
                return char1;
            }
            else
            {
                return char2;
            }
        }
    }
}
