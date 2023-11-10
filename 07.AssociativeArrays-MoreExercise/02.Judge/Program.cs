using System.Diagnostics.Metrics;

namespace _02.Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> users = new Dictionary<string, int>();
            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] arguments = input.Split(" -> ");
                string username = arguments[0];
                string constestName = arguments[1];
                int points = int.Parse(arguments[2]);

                if (!contests.ContainsKey(constestName))
                {
                    contests.Add(constestName, new Dictionary<string, int>());
                    contests[constestName][username] = points;
                }
                else
                {
                    if (!contests[constestName].ContainsKey(username))
                    {
                        contests[constestName][username] = points;
                    }
                    else
                    {
                        if (contests[constestName][username] < points)
                        {
                            contests[constestName][username] = points;
                        }
                    }
                }
            }

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count()} participants");

                int counter = 0;
                foreach (var name in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    counter++;
                    Console.WriteLine($"{counter}. {name.Key} <::> {name.Value}");
                }

                counter = 0;
            }

            Console.WriteLine("Individual standings:");

            foreach (var contest in contests)
            {
                foreach (var name in contest.Value)
                {
                    if (!users.ContainsKey(name.Key))
                    {
                        users.Add(name.Key, name.Value);
                    }
                    else
                    {
                        users[name.Key] = users[name.Key] + name.Value;
                    }
                }
            }

            int counter2 = 0;
            foreach (var name in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                counter2++;
                Console.WriteLine($"{counter2}. {name.Key} -> {name.Value}");
            }
        }
    }
}