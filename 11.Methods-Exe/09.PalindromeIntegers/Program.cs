using System;

namespace _9.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                int input = int.Parse(command);
                bool result = CheckIsPalindrome(input);

                Console.WriteLine(result.ToString().ToLower());

                command = Console.ReadLine();
            }
        }

        private static bool CheckIsPalindrome(int x)
        {

                if (x < 0)
                {
                    return false;
                }

                int div = 1;

                while (x / div >= 10)
                {
                    div *= 10;
                }

                while (x != 0)
                {
                    int l = x / div;
                    int r = x % 10;

                    if (l != r)
                    {
                        return false;
                    }

                    x = (x % div) / 10;
                    div /= 100;
                }

                return true;
            }
    }
}
