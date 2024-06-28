using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = true;
            Random random = new Random();            
            int randomNum = random.Next(1 , 11);
            Console.WriteLine("Welcome to the number guessing game");
            Console.WriteLine("A number between 1 and 10 will be generated");
            Console.WriteLine("If you guess the correct Number, You Win!");
            Console.WriteLine(randomNum);
            while (isCorrectGuess)
            {
                Console.WriteLine("Please Enter your guess.");
                int guess =Convert.ToInt32(Console.ReadLine());

                if (guess > randomNum)
                {
                   Console.WriteLine("Your guess is to High");
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Your guess is to Low");

                }
                else
                {
                    Console.WriteLine("Correct");
                    isCorrectGuess = true;
                }            
            }
            Console.WriteLine("Congratulation, you have Won the game");
            Console.ReadLine();
        }
    }
}
