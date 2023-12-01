namespace _03.HeroesOfCodeAndLogicVII
{
    class Hero
    {
        public Hero(string name, int hP, int mP)
        {
            Name = name;
            HP = hP;
            MP = mP;
        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());
            List<Hero> party = new List<Hero>();

            for (int i = 0; i < heroesCount; i++)
            {
                string[] heroArgs = Console.ReadLine().Split();
                string heroName = heroArgs[0];
                int hp = int.Parse(heroArgs[1]);
                int mp = int.Parse(heroArgs[2]);
                Hero hero = new Hero(heroName, hp, mp);
                party.Add(hero);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split(" - ");
                string command = arguments[0];
                string heroName = arguments[1];

                Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);
                switch (command)
                {
                    case "CastSpell":
                        int mpNeeded = int.Parse(arguments[2]);
                        string spellName = arguments[3];

                        //Cast spell
                        if (foundHero != null)
                        {
                            if (foundHero.MP >= mpNeeded)
                            {
                                foundHero.MP -= mpNeeded;
                                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {foundHero.MP} MP!");
                            }
                            else
                            {
                                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                            }

                        }
                        break;

                    case "TakeDamage":
                        int damage = int.Parse(arguments[2]);
                        string attacker = arguments[3];
                        if (foundHero != null)
                        {
                            foundHero.HP -= damage;

                            if (foundHero.HP > 0)
                            {
                                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {foundHero.HP} HP left!");
                            }
                            else
                            {
                                party.Remove(foundHero);
                                Console.WriteLine($"{heroName} has been killed by {attacker}!");

                            }
                        }
                        break;

                    case "Recharge":
                        int amountMP = int.Parse(arguments[2]);

                        if (foundHero != null)
                        {
                            int recoveredMP = Math.Min(amountMP, 200 - foundHero.MP);
                            foundHero.MP += recoveredMP;

                            Console.WriteLine($"{heroName} recharged for {recoveredMP} MP!");
                        }
                        break;

                    case "Heal":
                        int amountHP = int.Parse(arguments[2]);

                        if (foundHero != null)
                        {
                            int recoveredHP = Math.Min(amountHP, 100 - foundHero.HP);
                            foundHero.HP += recoveredHP;

                            Console.WriteLine($"{heroName} healed for {recoveredHP} HP!");
                        }
                        break;
                }
            }

            foreach (Hero hero in party)
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"HP: {hero.HP}");
                Console.WriteLine($"MP: {hero.MP}");
            }
        }
    }
}

/* 
2
Solmyr 85 120
Kyrre 99 50
Heal - Solmyr - 10
Recharge - Solmyr - 50
TakeDamage - Kyrre - 66 - Orc
CastSpell - Kyrre - 15 - ViewEarth
End

4
Adela 90 150
SirMullich 70 40
Ivor 1 111
Tyris 94 61
Heal - SirMullich - 50
Recharge - Adela - 100
CastSpell - Tyris - 1000 - Fireball
TakeDamage - Tyris - 99 - Fireball
TakeDamage - Ivor - 3 - Mosquito
End
*/