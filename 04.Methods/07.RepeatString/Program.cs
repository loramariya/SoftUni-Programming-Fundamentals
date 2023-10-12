namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = RepeatString(input, n);
            Console.WriteLine(result);
        }

        static string RepeatString (string input, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += input;
            }
            return result;
        }
    }
}