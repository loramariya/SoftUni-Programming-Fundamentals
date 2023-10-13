namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(n);
        }

        static void PrintMatrix(int n)
        {
            for (int rows = 1; rows <= n; rows++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}