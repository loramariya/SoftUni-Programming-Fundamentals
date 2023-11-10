namespace _03.MOBAChallenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            string input;
            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] commands = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                if (commands.Length == 3) // {player} -> {position} -> {skill}
                {
                    string player = commands[0];
                    string position = commands[1];
                    int skill = int.Parse(commands[2]);

                    if (!players.ContainsKey(player))
                    {
                        players[player] = new Dictionary<string, int>();
                    }

                    if (!players[player].ContainsKey(position))
                    {
                        players[player][position] = 0;
                    }

                    if (players[player][position] < skill)
                    {
                        players[player][position] = skill;
                    }
                }
                else // {player} vs {player}
                {
                    commands = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string player1 = commands[0];
                    string player2 = commands[1];

                    if (players.ContainsKey(player1) && players.ContainsKey(player2))
                    {
                        bool duelOccured = false;

                        foreach (var position1 in players[player1])
                        {
                            if (players[player2].ContainsKey(position1.Key))
                            {
                                duelOccured = true;

                                int totalSkill1 = players[player1].Values.Sum();
                                int totalSkill2 = players[player2].Values.Sum();

                                if (totalSkill1 > totalSkill2)
                                {
                                    players.Remove(player2);
                                }
                                else if (totalSkill1 < totalSkill2)
                                {
                                    players.Remove(player1);
                                }

                                break;
                            }
                        }

                        if (!duelOccured)
                        {
                            continue;
                        }

                    }
                }
            }

            foreach (var player in players
                         .OrderByDescending(x => x.Value.Values.Sum())
                         .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var position in player
                             .Value
                             .OrderByDescending(x => x.Value)
                             .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }

        }


    }
}