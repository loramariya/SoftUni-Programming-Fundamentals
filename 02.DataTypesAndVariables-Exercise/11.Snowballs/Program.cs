using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestSnow = 0, bestTime = 0, bestQuality = 0;
            BigInteger bestValue = 0;
            

            for (int i = 1; i <= n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime= int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > bestValue)
                {
                    bestValue = snowballValue;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }

    }
}