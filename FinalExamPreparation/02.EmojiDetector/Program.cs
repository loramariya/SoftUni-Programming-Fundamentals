using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string coolThresholdPattern = @"\d";
            string emojiPattern = @"(\*{2}|\:{2})(?<Emoji>[A-Z]{1}[a-z]{2,})\1";

            List<string> coolEmojis = new List<string>();

            string input = Console.ReadLine();

            ulong coolThreshold = 1;

            foreach (Match match in Regex.Matches(input, coolThresholdPattern))
            {
                coolThreshold *= ulong.Parse(match.Value);
            }

            MatchCollection matches = Regex.Matches(input, emojiPattern);
            foreach (Match match in matches)
            {
                string emojiStr = match.Groups["Emoji"].Value;

                ulong totalEmojiSum = 0;

                foreach (char character in emojiStr)
                {
                    totalEmojiSum += character;
                }

                if (totalEmojiSum >= coolThreshold)
                {
                    coolEmojis.Add(match.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            coolEmojis.ForEach(emoji => Console.WriteLine(emoji));
        }
    }
}
