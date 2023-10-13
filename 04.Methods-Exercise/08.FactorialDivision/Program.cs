namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(Factorial(firstNum) / Factorial(secondNum)):f2}");
        }

        static double Factorial(int number)
        {
            double factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}