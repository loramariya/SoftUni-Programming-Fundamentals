namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int sum = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(sum);
        }

        private static int GetMultipleOfEvenAndOdds(int number)
        {
            int sumEvens = GetSumOfEvenDigits(number);
            int sumOdds = GetSumOfOddDigits(number);
            return sumEvens * sumOdds;
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sumEven = 0;
            while (number > 0)
            {
                int nextNumber = number % 10;
                if (nextNumber % 2 == 0)
                {
                    sumEven += nextNumber;
                }
                number /= 10;
            }

            return sumEven;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sumOdd = 0;
            while (number > 0)
            {
                int nextNumber = number % 10;
                if (nextNumber % 2 == 1)
                {
                    sumOdd += nextNumber;
                }
                number /= 10;
            }

            return sumOdd;
        }

    }
}