namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input=Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrome(input));
            }
        }

        static bool IsPalindrome(string numStr)
        {
            int left = 0;
            int right = numStr.Length - 1;
           
            while (left < right)
            {
                if (numStr[left] != numStr[right])
                {
                    return false;
                }
                    left++;
                    right--;
            }

            return true;
        }
    }
}