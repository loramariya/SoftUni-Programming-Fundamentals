namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsTopNumber(int number)
        {
            if (IsDivisibleByEight(number) && HasOddDigit(number))
            {
                return true;
            }

            return false;
        }
        static bool HasOddDigit(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsDivisibleByEight(int number)
        {
            int sumOfDigits = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sumOfDigits += digit;
                number /= 10;
            }

            return sumOfDigits % 8 == 0;
        }
    }
}