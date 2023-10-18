﻿namespace _02.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count/ 2; i++)
            {
                int firstElement = numbers[i];
                int lastElement = numbers[numbers.Count-i -1];

                result.Add(firstElement + lastElement);
            }

            if (numbers.Count % 2 ==1)
            {
                int middleIndex = numbers.Count / 2;
                result.Add(numbers[middleIndex]);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}