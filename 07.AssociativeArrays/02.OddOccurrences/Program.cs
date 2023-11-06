namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordLowerCase = word.ToLower();
                if (!counts.ContainsKey(wordLowerCase))
                {
                    counts.Add(wordLowerCase, 0);
                }
                counts[wordLowerCase]++;
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
                
            }
        }
    }
}