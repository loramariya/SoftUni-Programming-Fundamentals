﻿namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];
            }
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}