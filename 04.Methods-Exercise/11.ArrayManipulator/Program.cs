using System.Security.Authentication;

namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToArray();

            string commands = "";
            while ((commands = Console.ReadLine()) != "end")
            {
                string[] arguments = commands.Split();

                switch (arguments[0])
                {
                    case "exchange":
                        int index = int.Parse(arguments[1]);
                        numbers = Exchange(numbers, index);
                        break;
                    case "max":
                        string maxType = arguments[1];
                        PrintMaxIndex(numbers, maxType);
                        break;
                    case "min":
                        string minType = arguments[1];
                        PrintMinIndex(numbers, minType);
                        break;
                    case "first":
                        int firstLength = int.Parse(arguments[1]);
                        string firstType = arguments[2];
                        PrintFirstElements(numbers, firstLength, firstType);
                        break;
                    case "last":
                        int lastLength = int.Parse(arguments[1]);
                        string lastType = arguments[2];
                        PrintLastElements(numbers, lastLength, lastType);
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static int[] Exchange(int[] array, int index)
        {
            if (CheckForOutOfBound(array, index))
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            int[] changedArray = new int[array.Length];
            int changedArrayIndex = 0;

            for (int i = index + 1; i <= array.Length - 1; i++)
            {
                changedArray[changedArrayIndex] = array[i];
                changedArrayIndex++;
            }
            for (int i = 0; i <= index; i++)
            {
                changedArray[changedArrayIndex] = array[i];
                changedArrayIndex++;
            }

            return changedArray;
        }

        private static void PrintMaxIndex(int[] numbers, string type)
        {
            int maxIndex = -1;
            int maxNumber = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                if (IsOddOrEven(number, type))
                {
                    if (number >= maxNumber)
                    {
                        maxNumber = number;
                        maxIndex = i;
                    }
                }
            }
            PrintIndex(maxIndex);
        }

        private static void PrintMinIndex(int[] numbers, string type)
        {
            int minIndex = -1;
            int minNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                if (IsOddOrEven(number, type))
                {
                    if (number <= minNumber)
                    {
                        minNumber = number;
                        minIndex = i;
                    }
                }
            }
            PrintIndex(minIndex);
        }

        private static void PrintFirstElements(int[] numbers, int count, string type)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            string firstElements = "";
            int elementCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsOddOrEven(numbers[i], type))
                {
                    firstElements += $"{numbers[i]}, ";
                    elementCount++;
                    if (elementCount >= count)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"[{firstElements.Trim(' ', ',')}]");
        }

        private static void PrintLastElements(int[] numbers, int count, string type)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string lastElements = "";
            int elementCount = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int number = numbers[i];
                if (IsOddOrEven(number, type))
                {
                    lastElements = $"{number}, " + lastElements;
                    elementCount++;
                    if (elementCount >= count)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"[{lastElements.Trim(' ', ',')}]");

        }
        private static bool IsOddOrEven(int number, string type)
        {
            return (type == "odd" && number % 2 != 0)
                   ||
                   (type == "even" && number % 2 == 0);
        }

        private static bool CheckForOutOfBound(int[] array, int index)
        {
            return index < 0 || index >= array.Length;
        }
        private static void PrintIndex(int index)
        {
            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }

}