namespace _03.P_rates
{
    public class City
    {
        public City(string name, int population, int gold)
        {
            Name = name;
            Population = population;
            Gold = gold;
        }

        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();

            string input;
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] tokens = input.Split("||");
                string cityName = tokens[0];
                int population = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);

                City city = cities.FirstOrDefault(c => c.Name == cityName);
                if (city != null)
                {
                    city.Population += population;
                    city.Gold += gold;
                }
                else
                {
                    cities.Add(new City(cityName, population, gold));
                }

            }

            input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split("=>");
                string command = tokens[0];
                string cityName = tokens[1];

                City targetCity = cities.FirstOrDefault(c => c.Name == cityName);

                if (command == "Plunder")
                {
                    int peopleKilled = int.Parse(tokens[2]);
                    int goldStolen = int.Parse(tokens[3]);

                    targetCity.Population -= peopleKilled;
                    targetCity.Gold -= goldStolen;

                    Console.WriteLine($"{cityName} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");

                    if (targetCity.Population <= 0 || targetCity.Gold <= 0)
                    {
                        Console.WriteLine($"{cityName} has been wiped off the map!");
                        cities.Remove(targetCity);
                    }

                }
                else //Prosper
                {
                    int goldAdded = int.Parse(tokens[2]);

                    if (goldAdded < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }

                    targetCity.Gold += goldAdded;

                    Console.WriteLine($"{goldAdded} gold added to the city treasury. {cityName} now has {targetCity.Gold} gold.");
                }

            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}

/*
Tortuga||345000||1250
Santo Domingo||240000||630
Havana||410000||1100
Sail
Plunder=>Tortuga=>75000=>380
Prosper=>Santo Domingo=>180
End

Nassau||95000||1000
San Juan||930000||1250
Campeche||270000||690
Port Royal||320000||1000
Port Royal||100000||2000
Sail
Prosper=>Port Royal=>-200
Plunder=>Nassau=>94000=>750
Plunder=>Nassau=>1000=>150
Plunder=>Campeche=>150000=>690
End
 */