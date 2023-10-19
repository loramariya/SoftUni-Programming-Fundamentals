namespace _01._Train
{
    internal class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string commands;
            while ((commands=Console.ReadLine()) != "end")
            {
                string[]arguments = commands.Split().ToArray();

                if (arguments[0] == "Add")
                {
                    wagons.Add(int.Parse(arguments[1]));
                }
                else
                {
                    int newPassengers = int.Parse(arguments[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + newPassengers <= maxCapacity)
                        {
                            wagons[i] += newPassengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}