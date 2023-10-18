namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input =default;
            while ((input=Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split().ToArray();
                string command = arguments[0];
                int number = int.Parse(arguments[1]);

                if (command == "Add")
                {
                    numbers.Add(number);
                }
                else if (command == "Remove")
                {
                    numbers.Remove(number);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(arguments[2]);
                    numbers.Insert(index, number);
                }
                else
                {
                    int index = number;
                    numbers.RemoveAt(index);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
