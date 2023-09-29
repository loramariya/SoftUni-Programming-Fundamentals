using System;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int[] input2 = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int sum = 0;
            bool isIdentical = false;

            for (int i = 0; i < input1.Length; i++)
            {
                int currentNum = input1[i];
                if (input1[i] != input2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isIdentical = false;
                    break;
                }
                else if (input1[i] == input2[i])
                {
                    sum += currentNum;
                    isIdentical = true;
                }
            }

            if (isIdentical==true)
            {

               Console.WriteLine($"Arrays are identical. Sum: {sum}");

            }
                   
        }
    }
}

