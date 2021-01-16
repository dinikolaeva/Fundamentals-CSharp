using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int trashKeyboardCount = 0;
            int displayCount = 0;


            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCount++;
                }
                
                if (i % 3 == 0)
                {
                    mouseCount++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCount++;
                    trashKeyboardCount++;

                    if (trashKeyboardCount % 2 == 0)
                    {
                        displayCount++;
                    }
                }
            }

            double expenses = (headsetPrice * headsetCount) + (mousePrice * mouseCount) + (keyboardPrice * keyboardCount) + (displayPrice * displayCount);

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
