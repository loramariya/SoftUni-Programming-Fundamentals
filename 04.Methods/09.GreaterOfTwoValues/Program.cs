namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (type == "string")
            {
                string result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else if (type == "int")
            {
                int result = GetMax(int.Parse(a), int.Parse(b));
                Console.WriteLine(result);
            }
            else //char
            {
                char result = GetMax(char.Parse(a), char.Parse(b));
                Console.WriteLine(result);
            }
        }

        private static string GetMax(string a, string b)
        {
            return a.CompareTo(b) == 1 ? a : b;
        }

        private static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
        private static char GetMax(char a, char b)
        {
            return a > b ? a : b;
        }
    }
}