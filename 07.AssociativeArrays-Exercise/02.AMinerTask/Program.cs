namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> resourceMap = new Dictionary<string,int>();

            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
               
                if (!resourceMap.ContainsKey(resource))
                {
                    resourceMap.Add(resource, 0);
                }

                int quantity = int.Parse(Console.ReadLine());

                resourceMap[resource] += quantity;
            }

            foreach (var resourceType in resourceMap)
            {
                Console.WriteLine($"{resourceType.Key} -> {resourceType.Value}");
            }
        }
    }
}
