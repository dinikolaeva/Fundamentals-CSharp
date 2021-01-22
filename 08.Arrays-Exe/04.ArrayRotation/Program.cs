using System;
using System.Linq;

namespace _4.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split()
                .ToArray();

            int numberOfRotationes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotationes; i++)
            {
                string rotateElement = arr[0];

                for (int j = 1; j < arr.Length; j++)
                {
                    string nextElement = arr[j];
                    arr[j - 1] = nextElement;
                }

                arr[arr.Length - 1] = rotateElement;
            }

            Console.Write(string.Join(" ", arr));
        }
    }
}
