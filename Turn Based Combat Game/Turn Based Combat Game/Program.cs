using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Based_Combat_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Need this Would be Change Some Codes.Because Some confusion still Have A right.

            int playerHp = 40;
            int ememyHp = 20;
            int playerAttack = 5;
            int ememyAttack = 7;

            int healAmount = 5;

            Random random = new Random();
            while (playerHp > 0 && ememyHp > 0)

            {
                //player turn
                Console.WriteLine("**Player Turn**");
                Console.WriteLine("Player Hp - " + playerHp + ". Enemy Hp -  " + ememyHp);
                Console.WriteLine("Enter 'A' to attack and 'H' to Heal.");

                string choice = Console.ReadLine();
                if (choice == "A" || choice == "a")
                {
                    ememyHp -= playerAttack;

                    Console.WriteLine("Player attack enemy and deals " + playerAttack + " damage!");
                }
                else
                {
                    playerHp += healAmount;

                    Console.WriteLine("Player restores " + healAmount + "Health points");
                }


            }

            if (ememyHp > 0)
            {
                Console.WriteLine("**Enemy Turn**");
                Console.WriteLine("Player Hp - " + playerHp + ". Enemy Hp -  " + ememyHp);

                int enemychoice = random.Next(0, 2);
                if (enemychoice == 0)
                {
                    playerHp -= ememyAttack;
                    Console.WriteLine("Enemy attacks and deals " + ememyAttack + " damage! ");
                }
                else
                {
                    ememyHp += healAmount;
                    Console.WriteLine("Enemy restores " + healAmount + " health Points. ");
                }
            }


            if (playerHp > 0)
            {
                Console.WriteLine("Congratulations, You Have Won!");
            }
            else
            {
                Console.WriteLine("You Loss!");
            }
        }

       


    }
}
