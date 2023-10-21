using System.Formats.Asn1;
using System.Runtime.InteropServices.ComTypes;

namespace _03.MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();
                string action = arguments[0];
                int index = int.Parse(arguments[1]);
                int value = int.Parse(arguments[2]);

                if (action == "Shoot")
                {
                    if (IsValidIndex(index, targets))
                    {
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (action == "Add")
                {
                    if (IsValidIndex(index, targets))
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else
                {
                    if (IsValidIndex(index, targets) &&
                        IsValidIndex(index + value, targets) &&
                        IsValidIndex(index - value, targets))
                    {
                        for (int i = 1; i <= value; i++)
                        {
                            targets.RemoveAt(index + i);
                        }

                        targets.RemoveAt(index);

                        for (int i = 1; i <= value; i++)
                        {
                            targets.RemoveAt(index - i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }

        private static bool IsValidIndex(int index, List<int> targets)
        {
            return index >= 0 && index < targets.Count;
        }
    }
}
