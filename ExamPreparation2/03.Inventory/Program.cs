namespace _03.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] commands = input.Split(" - ");


                switch (commands[0])
                {
                    case "Collect":
                        if (!inventory.Contains(commands[1]))
                        {
                            inventory.Add(commands[1]);
                        }

                        break;
                    case "Drop":

                        if (inventory.Contains(commands[1]))
                        {
                            inventory.Remove(commands[1]);
                        }

                        break;
                    case "Combine Items":
                        string[] items = commands[1].Split(":");
                        int oldItemIndex = inventory.IndexOf(items[0]);
                        ;
                        if (oldItemIndex >= 0)
                        {
                            if (oldItemIndex >= inventory.Count)
                            {
                                inventory.Add(items[1]);
                            }
                            else
                            {
                                inventory.Insert(oldItemIndex + 1, items[1]);

                            }
                        }
                        break;
                    case "Renew":

                        if (inventory.Contains(commands[1]))
                        {
                            inventory.Add(commands[1]);
                            inventory.Remove(commands[1]);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
