namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            int thirdInput = int.Parse(Console.ReadLine());
            int fourthInput = int.Parse(Console.ReadLine());

            int result = ((firstInput + secondInput) / thirdInput) * fourthInput;

            Console.WriteLine(result);
        }
    }
}