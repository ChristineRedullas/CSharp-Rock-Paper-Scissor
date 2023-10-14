using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;
            int wins = 0;
            int lose = 0;
            int tie = 0;


            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";
                




                while (player != "ROCK" && player != "PAPER" && player != "SCISSOR")
                {
                    Console.WriteLine("Enter ROCK, PAPER, SCISSOR");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                 
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSOR";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);
                

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a tie!");
                            tie++;
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Lose!");
                            lose++;
                        }
                        else
                        {
                            Console.WriteLine("You WIN");
                            wins++;
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You WIN");
                            wins++;
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a tie!");
                            tie++;
                        }
                        else
                        {
                            Console.WriteLine("You Lose!");
                            lose++;
                        }
                        break;
                    case "SCISSOR":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Lose!");
                            lose++;
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You WIN");
                            wins++;
                        }
                        else
                        {
                            Console.WriteLine("It's a tie!");
                            tie++;
                        }
                        break;
                }

                while (wins > 0 ||  tie > 0 || lose > 0)
                {

                    Console.WriteLine(" SCORE ");
                    Console.WriteLine("Wins: " + wins);
                    Console.WriteLine("Lose: " + lose);
                    Console.WriteLine("Tie: " + tie);
                    
                }


                while (answer != "Y" && answer != "N")
                {
                    Console.WriteLine("Do you wanna keep playing? Y / N");
                    answer = Console.ReadLine();
                    answer = answer.ToUpper();

                    if (answer == "Y")
                    {
                        playAgain = true;
                    } 
                    else if (answer == "N")
                    {
                        Console.WriteLine("Thanks for playing!");
                        playAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Please write a valid response!");
                    }
                }
                

            }



            Console.ReadKey();
        }

    }
}
