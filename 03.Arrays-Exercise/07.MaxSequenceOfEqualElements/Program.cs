using System.IO.Pipes;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int counter = 1;
            int max = 1;
            int element = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > max)
                {
                    max = counter;
                    element = numbers[i];
                }
            }

            int[] total = new int[max];

            for (int i = 0; i < total.Length; i++)
            {
                total[i] = element;
            }

            Console.WriteLine(string.Join(" ", total));
        }
    }
}