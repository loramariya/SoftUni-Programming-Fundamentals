namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int input = int.Parse(Console.ReadLine());
            int sum = 0;

            while (input > 0)
            {
                int lastDigit = input % 10;
                sum += lastDigit;
                input /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}