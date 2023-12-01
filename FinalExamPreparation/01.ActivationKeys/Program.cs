using System.Text;

namespace _01.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] tokens = input.Split(">>>");
                string command = tokens[0];

                if (command == "Contains")
                {
                    string substring = tokens[1];
                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string caseType = tokens[1];
                    int startIndex = int.Parse(tokens[2]);
                    int endIndex = int.Parse(tokens[3]);

                    if (caseType == "Upper")
                    {
                        string prefix = activationKey.Substring(0, startIndex);
                        string middle = activationKey
                            .Substring(startIndex, endIndex - startIndex)
                            .ToUpper();
                        string suffix = activationKey.Substring(endIndex);
                        activationKey = prefix + middle + suffix;
                        Console.WriteLine(activationKey);
                    }
                    else //Lower
                    {
                        string prefix = activationKey.Substring(0, startIndex);
                        string middle = activationKey
                            .Substring(startIndex, endIndex - startIndex)
                            .ToLower();
                        string suffix = activationKey.Substring(endIndex);

                        activationKey = prefix + middle + suffix;
                        Console.WriteLine(activationKey);
                    }
                }
                else // Slice
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    string firstPart = activationKey.Substring(0, startIndex);
                    string secondPart = activationKey.Substring(endIndex);

                    activationKey = firstPart + secondPart;
                    Console.WriteLine(activationKey);
                }
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
/*
abcdefghijklmnopqrstuvwxyz
Slice>>>2>>>6
Flip>>>Upper>>>3>>>14
Flip>>>Lower>>>5>>>7
Contains>>>def 
Contains>>>deF 
Generate
*/