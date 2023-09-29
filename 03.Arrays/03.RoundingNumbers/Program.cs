namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] roundNumbers =new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                roundNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {roundNumbers[i]}");
            }
        }
    }
} 