using System.ComponentModel;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string commands;
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] arguments = commands.Split();

                switch (arguments[0])
                {
                    case "Add":
                        list.Add(int.Parse(arguments[1]));
                        break;
                    case "Insert":
                        int number = int.Parse(arguments[1]);
                        int insertIndex = int.Parse(arguments[2]);
                        if (IsNotValidIndex(insertIndex, list.Count))
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }

                        list.Insert(insertIndex, number);
                        break;
                    case "Remove":
                        int removeIndex = int.Parse(arguments[1]);
                        if (IsNotValidIndex(removeIndex, list.Count))
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        list.RemoveAt(removeIndex);
                        break;
                    case "Shift":
                        int count = int.Parse(arguments[2]);
                        count %= list.Count;
                        if (arguments[1] == "left")
                        {
                            List<int> shiftedPart = list.GetRange(0, count);
                            list.RemoveRange(0, count);
                            list.InsertRange(list.Count, shiftedPart);
                        }
                        else if (arguments[1] == "right")
                        {
                            List<int> shiftedPart = list.GetRange(list.Count - count, count);
                            list.RemoveRange(list.Count - count, count);
                            list.InsertRange(0, shiftedPart);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }

        private static bool IsNotValidIndex(int index, int count)
        {
            return index < 0 || index >= count;
        }
    }

}
