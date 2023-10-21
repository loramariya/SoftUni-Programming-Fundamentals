namespace _02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split();
                int index1 = 0;
                int index2 = 0;

                switch (commands[0])
                {
                    case "swap":
                        {
                            index1 = int.Parse(commands[1]);
                            index2 = int.Parse(commands[2]);

                            Swap(numbers, index1, index2);

                            break;
                        }
                    case "multiply":
                    {
                        index1 = int.Parse(commands[1]);
                        index2 = int.Parse(commands[2]);

                        numbers[index1] = numbers[index1] * numbers[index2];
                        break;
                }
                    case "decrease":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i]--;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void Swap(List<int> numbers, int index1, int index2)
        {
            int temp = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = temp;
        }
    }
}