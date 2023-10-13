namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleIndex(input);
        }

        private static void PrintMiddleIndex(string input)
        {
            int textLength = input.Length;
            string middle = "";

            if(textLength % 2 ==0 ) 
            {
                middle += input[textLength / 2 - 1];
                middle += input[textLength / 2];
                Console.WriteLine(middle);
            }
            else
            {
                middle += input[textLength / 2];
                Console.WriteLine(middle);
            }
        }
    }
}