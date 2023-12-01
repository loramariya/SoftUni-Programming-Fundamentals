using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(?<word>(?:\@|\#)[A-Za-z]{3,}(?:\@|\#))(?<mirror>(?:\@|\#)[A-Za-z]{3,}(?:\@|\#))";

            MatchCollection matches = Regex.Matches(text, pattern);

            List<string> mirrors = new List<string>();
            int pairs = 0;

            foreach (Match match in matches)
            {
                string wordOne = match.Groups["word"].Value;
                string wordTwo = match.Groups["mirror"].Value;

                char a = wordOne[0];
                if (wordOne[0] == wordOne[wordOne.Length - 1] &&
                    wordOne[0] == wordTwo[0] &&
                    wordOne[0] == wordTwo[wordTwo.Length - 1])
                {
                    pairs++;

                    var mirroredWord = new string(wordTwo.Reverse().ToArray());

                    if (wordOne == mirroredWord)
                    {
                        string matchSymbolsPattern = @"(?:\@|\#)";
                        string cleanWord = Regex.Replace(wordOne, matchSymbolsPattern, "");
                        string cleanMirror = Regex.Replace(wordTwo, matchSymbolsPattern, "");
                        mirrors.Add($"{cleanWord} <=> {cleanMirror}");
                    }
                }
            }
            if (pairs == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{pairs} word pairs found!");
            }

            if (mirrors.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrors));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}