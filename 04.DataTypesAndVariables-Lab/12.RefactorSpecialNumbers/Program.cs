using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int digit = i;
                int sumOfDigits = 0;

                while (digit>0)
                {
                    sumOfDigits += digit % 10;
                    digit = digit / 10;
                }

                bool isSpecial = false;

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    isSpecial = true;
                    Console.WriteLine("{0} -> {1}", i, isSpecial);
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", i, isSpecial);
                }
            }

            //int kolkko = int.Parse(Console.ReadLine());
            //int obshto = 0;
            //int takova = 0;
            //bool toe = false;
            //for (int ch = 1; ch <= kolkko; ch++)
            //{
            //    takova = ch;
            //    while (ch > 0)
            //    {
            //        obshto += ch % 10;
            //        ch = ch / 10;
            //    }
            //    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
            //    Console.WriteLine("{0} -> {1}", takova, toe);
            //    obshto = 0;
            //    ch = takova;
            //}

        }
    }
}
