using System;

namespace _03.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double input1 = double.Parse(Console.ReadLine());
            double input2 = double.Parse(Console.ReadLine());

            const double eps = 0.000001;

            double difference = Math.Abs(input1 - input2);
            bool isDifferent = false;

            if (difference < eps)
            {
                isDifferent = true;
            }
            else
            {
                isDifferent = false;
            }

            Console.WriteLine(isDifferent);
        }
    }
}
