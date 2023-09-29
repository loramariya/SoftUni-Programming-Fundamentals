namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int current = input[i];
                if (current % 2 == 0)
                {
                    evenSum += current;
                }
                else
                {
                    oddSum += current;
                }
            }
            int result = evenSum - oddSum;
            Console.WriteLine(result);
        }
    }
}