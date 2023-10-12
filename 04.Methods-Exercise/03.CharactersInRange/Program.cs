namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
           char char1 = char.Parse(Console.ReadLine());
           char char2 = char.Parse(Console.ReadLine());

            PrintCharactersInBetween (char1, char2);
        }

        static void PrintCharactersInBetween(char startChar, char endChar)
        {
            if (startChar > endChar)
            {
                char temp = startChar;
                startChar = endChar;
                endChar = temp;
            }
            for (int i = startChar; i < endChar; i++)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}