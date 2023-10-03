using System.Diagnostics.Metrics;

namespace _01.Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];

            int[] currentValue = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
                string currentInput = arr[i];

                sum = 0;

                for (int j = 0; j < currentInput.Length; j++)
                {
                    char digit = currentInput[j];
                    int value = (int)digit;

                    if (digit == 'a' || digit == 'i' || digit == 'e' || digit == 'o' || digit == 'u'
                       || digit == 'A' || digit == 'I' || digit == 'E' || digit == 'O' || digit == 'U')
                    {
                        sum += value * currentInput.Length;
                    }
                    else
                    {
                        sum += value / currentInput.Length;
                    }
                }
                currentValue[i] = sum;
            }
            Array.Sort(currentValue);
            for (int i = 0; i < currentValue.Length; i++)
            {
                Console.WriteLine(currentValue[i]);
            }
        }
    }
}