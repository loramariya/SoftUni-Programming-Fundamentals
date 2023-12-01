using System.Data.SqlTypes;
using System.Text;

namespace _01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string line;
            while ((line = Console.ReadLine()) != "Done")
            {
                string[] tokens = line.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "TakeOdd":
                        string newPassword = string.Empty;

                        for (int i = 1; i < password.Length; i += 2)
                        {
                            newPassword += password[i];
                        }
                        Console.WriteLine(newPassword);
                        password = newPassword;
                        break;
                    case "Cut":
                        int index = int.Parse(tokens[1]);
                        int length = int.Parse(tokens[2]);

                        string textToRemove = password.Substring(index, length);
                        int firstOccurence = password.IndexOf(textToRemove);

                        if (firstOccurence != -1)
                        {
                            password = password.Remove(firstOccurence, length);
                        }
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string substring = tokens[1];
                        string substitute = tokens[2];

                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, substitute);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
/*
Siiceercaroetavm!:?:ahsott.:i:nstupmomceqr  
TakeOdd 
Cut 15 3 
Substitute :: - 
Substitute | ^ 
Done 
*/