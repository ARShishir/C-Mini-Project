using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
 class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int playerPoints=0;
            int enemyRandomNum;
            int enemyPoints=0;
               
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("press any key to roll the dice.");
                Console.ReadKey();
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("\nYou rolled a " + playerRandomNum);
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);
                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI Rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("player win this round");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    Console.WriteLine("Enemy win this round");
                }
                else {
                    Console.WriteLine("Draw");
                }
                Console.WriteLine("The score is now - player: " + playerPoints + " Enemy: " + enemyPoints + " ");
                Console.WriteLine();

            
            }
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You win");
            }
            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("You Lose!");
            }

            Console.ReadKey();

        }
    }
}
