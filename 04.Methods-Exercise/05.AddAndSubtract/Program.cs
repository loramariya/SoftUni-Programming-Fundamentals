namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = Sum(num1, num2);
            result = Subtract(result, num3);
            Console.WriteLine(result);
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Subtract(int result, int num3)
        {
            return result - num3;
        }
    }
}