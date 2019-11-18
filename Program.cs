using System;

namespace NumberGuessingGame
{
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {

                // Set correct number
                // int correctNumber = 7;

                // Create a new Random Object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // while loop guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        continue;
                    }

                    // Parse to int from string
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "Congratulations! You guessed correctly!");


                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            // Set App Vars
            string appName = "Number Guessing Game";
            string appVersion = "1.0.0";
            string appAuthor = "Dom Patino";

            // Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask for user name
            Console.WriteLine("Please enter your name");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, shall we being the game?", inputName);

        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change Text Color
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
