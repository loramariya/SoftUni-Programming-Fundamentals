namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Person> list = new List<Person>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();
                string name = arguments[0];
                string id = arguments[1];
                int age = int.Parse(arguments[2]);


                Person personFound = list.FirstOrDefault(person => person.ID == id);

                if (personFound != null)
                {
                    personFound.Age = age;
                    personFound.Name = name;
                }
                else
                {
                    list.Add(new Person(name, id, age));
                }

            }
            List<Person> orderedPersons = list.OrderBy(person => person.Age).ToList();
            foreach (Person person in orderedPersons)
            {
                Console.WriteLine(person);
            }
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}