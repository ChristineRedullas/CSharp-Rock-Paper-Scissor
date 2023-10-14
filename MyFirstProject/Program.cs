using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;

            int wins = 0;
            int losses = 0;
            int ties = 0;

            while (playAgain)
            {
                Console.Clear(); // Clear the console for a cleaner output

                string[] choices = { "ROCK", "PAPER", "SCISSOR" };

                string playerChoice;
                string computerChoice = choices[random.Next(0, 3)];

                Console.WriteLine("Enter ROCK, PAPER, or SCISSOR:");
                playerChoice = Console.ReadLine().ToUpper();

                if (Array.IndexOf(choices, playerChoice) == -1)
                {
                    Console.WriteLine("Invalid choice. Try again.");
                    continue;
                }

                Console.WriteLine("Player: " + playerChoice);
                Console.WriteLine("Computer: " + computerChoice);

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                    ties++;
                }
                else if ((playerChoice == "ROCK" && computerChoice == "SCISSOR") ||
                         (playerChoice == "PAPER" && computerChoice == "ROCK") ||
                         (playerChoice == "SCISSOR" && computerChoice == "PAPER"))
                {
                    Console.WriteLine("You WIN!");
                    wins++;
                }
                else
                {
                    Console.WriteLine("You Lose!");
                    losses++;
                }

                Console.WriteLine("Wins: " + wins);
                Console.WriteLine("Losses: " + losses);
                Console.WriteLine("Ties: " + ties);

                Console.WriteLine("Do you want to play again? (Y/N)");
                string answer = Console.ReadLine().ToUpper();

                while (answer != "Y" && answer != "N")
                {
                    Console.WriteLine("Please write a valid response (Y/N)");
                    answer = Console.ReadLine().ToUpper();
                }

                if (answer == "N")
                {
                    Console.WriteLine("Thanks for playing!");
                    playAgain = false;
                }
            }
        }
    }
}
