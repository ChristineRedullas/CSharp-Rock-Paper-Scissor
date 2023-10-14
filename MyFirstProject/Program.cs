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
                        computer = "PAPPER";
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
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else
                        {
                            Console.WriteLine("You WIN");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You WIN");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a tie!");
                        }
                        else
                        {
                            Console.WriteLine("You Lose!");
                        }
                        break;
                    case "SCISSOR":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You WIN");
                        }
                        else
                        {
                            Console.WriteLine("It's a tie!");
                        }
                        break;
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
