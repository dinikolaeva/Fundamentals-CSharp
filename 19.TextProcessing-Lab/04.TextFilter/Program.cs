using System;
using System.Linq;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            string replaceWord = string.Empty;

            foreach (var word in banWords)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    replaceWord += "*";
                }

                text = text.Replace(word, replaceWord);
                replaceWord = string.Empty;

            }
            
            Console.WriteLine(text);
        }
    }
}
