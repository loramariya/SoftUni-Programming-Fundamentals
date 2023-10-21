namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main()
        {
            List<string> elements = Console.ReadLine()
                .Split()
                .ToList();

            string input;
            int movesCount = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                int[] indexes = input.Split().Select(int.Parse).ToArray();
                int firstIndex = indexes[0];
                int secondIndex = indexes[1];

                movesCount++;

                if (firstIndex == secondIndex 
                    || IndexOutOfBound(firstIndex, elements)
                    || IndexOutOfBound(secondIndex, elements))
                {
                    string newSymbol = $"-{movesCount}a";
                    List<string> newElements = new List<string> { newSymbol, newSymbol };
                    int middleIndex = elements.Count / 2;
                    elements.InsertRange(middleIndex, newElements);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (elements[firstIndex] == elements[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");

                        if (firstIndex < secondIndex)
                        {
                            elements.RemoveAt(secondIndex);
                            elements.RemoveAt(firstIndex);
                        }
                        else
                        {
                            elements.RemoveAt(firstIndex);
                            elements.RemoveAt(secondIndex);
                        }
                       
                    }
                    else if (elements[firstIndex] != elements[secondIndex])
                    {
                        Console.WriteLine("Try again!");
                    }
                    
                    if (elements.Count == 0)
                    {
                        Console.WriteLine($"You have won in {movesCount} turns!");
                        break;
                    }
                   
                }
            }

            if (elements.Count != 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }

        private static bool IndexOutOfBound(int index, List<string> list)
        {
            return index <0 || index >= list.Count;
        }
    }
}
