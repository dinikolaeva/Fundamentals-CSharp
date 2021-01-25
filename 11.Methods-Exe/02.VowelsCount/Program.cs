using System;
using System.Linq;

namespace _2.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int vowels = PrintVowelsInWord(input);
            Console.WriteLine(vowels);
        }

        static int PrintVowelsInWord(string input)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
            return input.Count(x => vowels.Contains(x));
        }
    }
}
