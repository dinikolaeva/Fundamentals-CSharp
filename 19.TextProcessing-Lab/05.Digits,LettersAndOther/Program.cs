using System;
using System.Text;

namespace _05.Digits_LettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();

            StringBuilder sbDigits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {

                if (char.IsDigit(text[i]))
                {
                    sbDigits.Append(text[i]);
                }
                else if (char.IsLetter(text[i]))
                {
                    letters.Append(text[i]);
                }
                else
                {
                    other.Append(text[i]);
                }
            }
            Console.WriteLine(sbDigits);
            Console.WriteLine(letters);
            Console.WriteLine(other);

        }

        
    }
}
