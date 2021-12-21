using System;

namespace ProgChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            // Ask for input
            Console.WriteLine("Let's Begin:");
            do {
                // Wait and read input
                string input = Console.ReadLine();
                if (input == "exit") 
                    running = false;
                else {
                    // Clean input
                    string cleanInput = CleanString(input);
                    // Calculate palindrone
                    (bool, int) result = IsPalindrone(cleanInput);
                    Console.WriteLine($"Palindrone: {result.Item1}, Length: {result.Item2}");
                }

            } while (running);
        }

        static string CleanString(string thestr)
        {
            string newstr = "";
            // For each character in string
            foreach (char c in thestr) {
                // If it is not a lowercase letter
                if (c > 122 || c < 97) {
                    // If it is an uppercase letter
                    if (c >= 65 && c <= 90) {
                        // Convert to lower case
                        newstr = newstr + (char)(c + 97 - 65);
                    }
                }
                // If it is a lowercase letter, add it to string
                else {
                    newstr = newstr + c;
                }
            }

            return newstr;
        }

        static (bool, int) IsPalindrone(string str) 
        {
            // Base cases
            if (str.Length == 0) {
                return (true, 0);
            }

            if (str.Length == 1) {
                return (true, 1);
            }

            // Check the outer characters
            if (str[0] == str[str.Length - 1]) {
                string newStr = str.Substring(1, str.Length - 2);
                (bool, int) result = IsPalindrone(newStr);
                if (result.Item1)
                    return (result.Item1, result.Item2 + 1); 
                else
                    return (false, 0);
            }
            else 
                return (false, 0);
        }

    }
}
