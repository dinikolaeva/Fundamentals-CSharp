using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            // integers?
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int counter = 0;
            double originalValue = n * 0.50;

            while (m <= n)
            {

                if (n == originalValue)
                {
                    if (y > 0)
                    {
                        n = n / y;
                    }

                    if (n < m)
                    {
                        break;
                    }
                }

                n -= m;
                counter++;
            }

            Console.WriteLine(n);
            Console.WriteLine(counter);
        }
    }
}
