namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] passangers = new int[n];
            int sum = 0;
            for (int i = 0; i <n; i++)
            {
                int numberOfPassangers = int.Parse(Console.ReadLine());
                passangers[i] = numberOfPassangers;
                sum += numberOfPassangers;
                            
            }
            for (int i = 0;i <n;i++)
            {
                Console.Write(passangers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
