namespace _02.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split('|');

            int health = 100;
            int bitcoins = 0;

            int currentHealth = 0;
            int tempHealth = 0;
            int roomCounter = 0;
            bool notDead = true;

            for (int i = 0; i < rooms.Length; i++)
            {
                roomCounter++;
                string command = rooms[i];
                string[] argument = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (argument[0] == "potion" && notDead)
                {
                    currentHealth = health;
                    tempHealth = health;
                    currentHealth += int.Parse(argument[1]);
                    if (currentHealth <= 100)
                    {
                        health += int.Parse(argument[1]);

                        Console.WriteLine($"You healed for {argument[1]} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else if (currentHealth > 100)
                    {
                        int diff = 100 - tempHealth;
                        health = 100;
                        Console.WriteLine($"You healed for {diff} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                else if (argument[0] == "chest" && notDead)
                {
                    int currentCoin = int.Parse(argument[1]);
                    bitcoins += currentCoin;
                    Console.WriteLine($"You found {currentCoin} bitcoins.");
                }
                else
                {
                    string monster = argument[0];
                    int attack = int.Parse(argument[1]);
                    health -= attack;
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {roomCounter}");
                        notDead = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                }
            }

            if (notDead)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
