using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            double result;
            string answer;
            Console.WriteLine("Hello!, Welcome to the calculator program! ");
            Console.WriteLine("Please Enter the First Number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please Enter + for addition, - for Subtraction, *  for Multiplication , / for Division");

            answer = Console.ReadLine();

            if (answer == "+")
            {
                result = num1 + num2;
            }
            else if (answer == "-" )
            {
                result = num1 - num2;
            }
            else if (answer == "*" )
            {
                result = num1 * num2;
            }
            else if (answer == "/")
            {
                result = num1 / num2;
            }
            else
            {
                result = 0;
            }
            Console.WriteLine("The result is: " + result);
            Console.WriteLine("Thank you for using the calculator Program! ");

        }
    }
}
