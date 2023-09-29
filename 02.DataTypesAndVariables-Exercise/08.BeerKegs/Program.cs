namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKegModel = "";
            decimal biggestKegVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                decimal volume = (decimal)Math.PI * (radius * radius) * height;

                if (volume > biggestKegVolume)
                {
                    biggestKegVolume = volume;
                    biggestKegModel = model;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}