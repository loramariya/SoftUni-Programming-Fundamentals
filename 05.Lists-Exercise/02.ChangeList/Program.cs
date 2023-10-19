namespace _02.ChangeList
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string commands;
            while ((commands = Console.ReadLine()) != "end")
            {
                string[] arguments = commands.Split().ToArray();
                string command = arguments[0];
                int element = int.Parse(arguments[1]);
                if (command == "Delete")
                {
                    list.RemoveAll(x => x == element);
                }
                else if(command == "Insert")
                {
                    int index = int.Parse(arguments[2]);
                    list.Insert(index, element);
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}