using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {

            int playerScore = 0;
            int enemyScore = 0;
            Random random = new Random();
            Console.WriteLine("Welcome to the Rock Paper Scissors! ");

            while (playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("Player Score - " + playerScore + " Enemy Score - " + enemyScore);
                Console.WriteLine("Please Enter 'R' for Rock, 'P' For Paper, 'S' for Scissors");

                string playerChoice = Console.ReadLine();
                 int enemyChoice = random.Next(0,3);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy Chooses Rock");

                    switch (playerChoice)
                    {

                        case "r": 
                            Console.WriteLine("Tie!");
                        break;

                        case "p": 
                            Console.WriteLine("Player wins This Round");
                            playerScore++;
                            break; 

                        case "s": 
                            Console.WriteLine("Enemy Wins this Round");
                            enemyScore++;
                            break;

                        default :
                            Console.WriteLine("Try Again");
                            break;
                    }
                }
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy Chooses Paper");
                    switch (playerChoice)
                    {

                        case "p":
                            Console.WriteLine("Tie!");
                            break;

                        case "s":
                            Console.WriteLine("Player wins This Round");
                            playerScore++;
                            break;

                        case "r":
                            Console.WriteLine("Enemy Wins this Round");
                            enemyScore++;
                            break;

                        default:
                            Console.WriteLine("Try Again");
                            break;
                    }
                }

                else if (enemyChoice == 2)
                {

                    Console.WriteLine("Enemy Chooses Scissors");
                    switch (playerChoice)
                    {
                        case "s":
                            Console.WriteLine("Tie!");
                            break;

                        case "p":
                            Console.WriteLine("Player wins This Round");
                            playerScore++;
                            break;

                        case "r":
                            Console.WriteLine("Enemy Wins this Round");
                            enemyScore++;
                            break;

                        default:
                            Console.WriteLine("Try Again");
                            break;
                    }
                }
                else 
                { 
                        Console.WriteLine("Please Choice Write Number!"); 
                }

            }

            if (playerScore == 3)
            {
                Console.WriteLine("You Win !");
            }
            else
            {
                Console.WriteLine("You Loss!");
            }

        }
    }
}
