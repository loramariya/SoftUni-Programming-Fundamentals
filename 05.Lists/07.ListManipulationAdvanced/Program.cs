using System.ComponentModel;

namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            bool isChanged = false;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] newCommand = command.Split().ToArray();
                string firstCommand = newCommand[0];
               

                if (firstCommand == "Add")
                {
                    int number = int.Parse(newCommand[1]);
                    numbers.Add(number);
                    isChanged = true;
                }
                else if (firstCommand == "Remove")
                {
                    int number = int.Parse(newCommand[1]);
                    numbers.Remove(number);
                    isChanged = true;
                }
                else if (firstCommand == "Insert")
                {
                    int number = int.Parse(newCommand[1]);
                    int index = int.Parse(newCommand[2]);
                    numbers.Insert(index, number);
                    isChanged = true;
                }
                else if (firstCommand == "RemoveAt")
                {
                    int index = int.Parse(newCommand[1]);
                    numbers.RemoveAt(index);
                    isChanged = true;
                }
                else if (newCommand[0] == "Contains")
                {
                    int number = int.Parse(newCommand[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (newCommand[0] == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (newCommand[0] == "PrintOdd")
                {

                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (newCommand[0] == "GetSum")
                {
                    Console.WriteLine(string.Join(" ", numbers.Sum()));
                }
                else if (newCommand[0] == "Filter")
                {
                    string condition = newCommand[1];
                    int num = int.Parse(newCommand[2]);

                    switch (condition)
                    {
                        case "<":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x < num)));
                            break;

                        case ">":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x > num)));
                    
                            break;
                        case ">=":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x >= num)));
                            break;
                        case "<=":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x <= num)));
                            break;

                    }
                }
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
