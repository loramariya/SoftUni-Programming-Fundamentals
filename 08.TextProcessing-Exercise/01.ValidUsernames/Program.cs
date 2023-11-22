namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (string username in usernames)
            {
                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }

                if (IsValid(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        private static bool IsValid(string username)
        {
            return username.All(x => char.IsLetterOrDigit(x) 
            || x == '-' 
            || x == '_');
        }
    }
}