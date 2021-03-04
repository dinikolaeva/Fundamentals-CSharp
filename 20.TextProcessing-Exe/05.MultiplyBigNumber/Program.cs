using System;
using System.Linq;
using System.Text;

namespace _5.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().Trim('0');
            int digit = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            int result = 0;
            int rest = 0;

            if (number == string.Empty || digit == 0)
            {
                Console.WriteLine(0);
                return;
            }

            foreach (var num in number.Reverse())
            {
                int multiplayer = int.Parse(num.ToString());

                result = digit * multiplayer;

                if (rest > 0)
                {
                    result += rest;
                }

                sb.Insert(0, result % 10);

                rest = result / 10;

            }

            if (rest > 0)
            {
                sb.Insert(0, rest);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
