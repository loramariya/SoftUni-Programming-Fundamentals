using System.Globalization;

namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretMessage = Console.ReadLine();


            string line;
            while ((line = Console.ReadLine()) != "Reveal")
            {
                string[] tokens = line.Split(":|:");
                string command = tokens[0];


                if (command == "InsertSpace")
                {
                    int index = int.Parse(tokens[1]);

                    secretMessage = secretMessage.Insert(index, " ");
                }
                else if (command == "ChangeAll")
                {
                    string substring = tokens[1];
                    string replacement = tokens[2];

                    secretMessage = secretMessage.Replace(substring, replacement);
                }
                else  //Reverse
                {
                    string substring = tokens[1];
                    int substingIndex = secretMessage.IndexOf(substring);

                    if (substingIndex == -1)
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                    secretMessage = secretMessage.Remove(substingIndex, substring.Length);
                    string reversedSubstring = new string(substring.Reverse().ToArray());
                    secretMessage += reversedSubstring;
                }

                Console.WriteLine(secretMessage);
            }

            Console.WriteLine($"You have a new text message: {secretMessage}");
        }
    }
}
