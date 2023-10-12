namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            CheckForVowels(input);
        }

        private static void CheckForVowels(string input)
        {
            int vowelCounter = 0;
            foreach (char item in input)
            {
                switch (item)
                {
                    case 'a':
                    case 'e':
                    case 'o':
                    case 'u':
                    case 'i':
                        vowelCounter++;
                        break;
                }
            }
            Console.WriteLine(vowelCounter);

        }
    }
}