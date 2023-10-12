using System.ComponentModel.Design;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool length = CheckLength(password);
            bool symbolCheck = CheckSpecialSymbols(password);
            bool twoDigitsCheck = CheckForTwoDigits(password);

            if (!length)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!symbolCheck)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!twoDigitsCheck)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (length && symbolCheck && twoDigitsCheck)
            {
                Console.WriteLine("Password is valid");
            }

        }



        static bool CheckLength(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }
            return true;
        }
        static bool CheckSpecialSymbols(string password)
        {
            foreach (var symbol in password)
            {
                if (symbol >= 65 && symbol <= 90 ||
                        symbol >= 97 && symbol <= 122 ||
                    symbol >= 48 && symbol <= 57)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        private static bool CheckForTwoDigits(string password)
        {
            int digitCounter = 0;
            foreach (var symbol in password)
            {
                if (symbol >= 48 && symbol <= 57)
                {
                    digitCounter++;
                }
            }

            if (digitCounter < 2)
            {
                return false;
            }

            return true;
        }
    }
}