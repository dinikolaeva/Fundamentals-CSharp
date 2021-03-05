using System;
using System.Text;
using System.Linq;

namespace _6.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i] != text[i+1])
                {
                    sb.Append(text[i]);
                }

            }

            char symbol = text[text.Length - 1];
            sb.Append(symbol);

            Console.WriteLine(sb.ToString());
            
        }
    }
}
