namespace _07.ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimeter = Console.ReadLine();

            string result = (firstName + delimeter + secondName);
            Console.WriteLine(result);
        }
    }
}