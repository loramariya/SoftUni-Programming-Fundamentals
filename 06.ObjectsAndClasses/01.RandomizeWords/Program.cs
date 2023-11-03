namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            Random random= new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = random.Next(0,input.Length);

                string currentWord = input[i];
                string randomWord = input[randomIndex];

                input[i] = randomWord;
                input[randomIndex] = currentWord;
            }

            foreach (string word in input)
            {
                Console.WriteLine(word);
            }

        }
    }
}