using System;
using System.Text;

namespace _4.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = (char)(input[i] + 3);
                sb.Append(currentChar);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
