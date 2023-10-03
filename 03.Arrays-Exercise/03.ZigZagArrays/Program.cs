namespace _03.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isFirstArrSelected = true;
            string[] firstArr = new string[n];
            string[] secondArr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                string[] numbersArr = numbers.Split();
                
                if (isFirstArrSelected)
                {
                    firstArr[i] = numbersArr[0];
                    secondArr[i] = numbersArr[1];
                }
                else
                {
                    firstArr[i] = numbersArr[1];
                    secondArr[i] = numbersArr[0];
                }

                isFirstArrSelected = !isFirstArrSelected;
            }
            Console.WriteLine(string.Join(" ",firstArr));
            Console.WriteLine(string.Join(" ",secondArr));
        }
    }
}