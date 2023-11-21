namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(filter))
            {
                int index = text.IndexOf(filter);
                text = text.Remove(index, filter.Length);
            }
            
            Console.WriteLine(text);
        }
    }
}