﻿namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int topInteger = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTop = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {

                    if (numbers[i] <= numbers[j])
                    {
                        isTop = false;
                        break;
                    }

                }
                if (isTop)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}