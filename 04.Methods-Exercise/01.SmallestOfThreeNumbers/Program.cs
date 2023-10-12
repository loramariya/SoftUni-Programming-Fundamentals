namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            PrintSmallestNumber(a,b,c);
        }

        private static void PrintSmallestNumber(int a, int b, int c)
        {
            int smallestNumber = int.MaxValue;

            if (a <= smallestNumber && a <= b && a <= c)
            {
                smallestNumber = a;
            }
            else if (b <= smallestNumber && b <= a && b <= c)
            {
                smallestNumber = b;
            }
            else if (c <= smallestNumber && c <= b && c <= a)
            {
                smallestNumber = c;
            }

            Console.WriteLine(smallestNumber);
        }
    }
}