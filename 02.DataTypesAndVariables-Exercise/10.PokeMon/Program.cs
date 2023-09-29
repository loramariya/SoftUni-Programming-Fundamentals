namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //poke power
            int m = int.Parse(Console.ReadLine()); //distance between poke targets
            int y = int.Parse(Console.ReadLine()); //exhaustionFactor
            int targetCounter = 0, originalNValue = n;
            while (n >= m)
            {
                n -= m;
                targetCounter++;

                double nAsDouble = (double)n;


                if (nAsDouble == originalNValue * 0.5 )
                {
                    if (y > 0)
                    {
                        n /= y;
                    }
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(targetCounter);
        }
    }
}