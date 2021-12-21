using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Is the game running
            bool playing = true;
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            // The guess
            string guess = "";
            // The guess as a number
            int guessNum = -1;
            // The number of guesses
            int guessCount = 0;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            while(playing) {
                // Ask for input
                Console.WriteLine("What's your guess?");
                // Wait and read input
                guess = Console.ReadLine();
                // Convert the input to a number
                bool succeeded = false;
                succeeded = Int32.TryParse(guess, out guessNum);
                if (!succeeded) {
                    Console.WriteLine("Hmm, that doesn't look like a number. Try again.");
                }
                else {
                    guessCount++;
                    // If the exit code is entered, stop playing
                    if (guessNum == -1) {
                        playing = false;
                    }

                    // Check if guess is correct
                    else if (guessNum == theNumber) {
                        Console.WriteLine($"You got it in {guessCount} guesses!!");
                        playing = false;
                    }
                    // Check whether it is higher or lower
                    else {
                        Console.WriteLine("Nope, {0} than that", guessNum < theNumber ? "higher" : "lower");
                    }
                }
            }
            
        }
    }
}
