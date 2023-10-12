namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculation(a, operation, b));
        }

        static double Calculation(double a, string operations, double b)
        {
            double result = 0;

            switch (operations)
            {
                case "/": result = a / b; break;
                case "*": result = a * b; break;
                case "+": result = a + b; break;
                case "-": result = a - b; break;
            }

            return result;
        }
    }
}