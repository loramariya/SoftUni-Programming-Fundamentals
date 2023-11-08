using System.Data;
using System.Globalization;

namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> registeredUsers = new Dictionary<string, User>();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string command = arguments[0];
                string name = arguments[1];


                if (command == "register")
                {
                    string licensePlate = arguments[2];
                    User newUser = new User(name, licensePlate);

                    if (registeredUsers.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");

                    }
                    else
                    {
                        registeredUsers.Add(newUser.Name, newUser);
                        Console.WriteLine($"{newUser.Name} registered {licensePlate} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (!registeredUsers.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");

                    }
                    else
                    {
                        registeredUsers.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }

            foreach (KeyValuePair<string, User> userPair in registeredUsers)
            {
                Console.WriteLine(userPair.Value);
            }
        }

        class User
        {
            public User(string name, string licensePlate)
            {
                Name = name;
                LicensePlate = licensePlate;
            }

            public string Name { get; set; }
            public string LicensePlate { get; set; }

            public override string ToString()
            {
                return $"{Name} => {LicensePlate}";
            }

        }

    }
}
