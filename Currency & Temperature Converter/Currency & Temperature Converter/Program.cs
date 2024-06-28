using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency___Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome ! Please Enter 'C' to use the currency converter Or 'T' for Temperature Converter.");
                string answer = Console.ReadLine();
                if (answer == "C" || answer == "c")
                {
                    Console.WriteLine("You Have Selected the currency converter.");
                    Console.WriteLine("Please Enter 'USD' for Doller To Bangladeshi currency Or 'BDT' for Bangladeshi currency to Doller .");
                    string choice = Console.ReadLine();

                    if (choice == "usd" || choice == "USD" || choice == "UsD" || choice == "Usd")
                    {
                        Console.WriteLine("please Enter Your Amount in Doller.");
                        float doller = float.Parse(Console.ReadLine());
                        float taka = doller * 116f;
                        Console.WriteLine("The amount in BDT is " + taka.ToString("0.00"));

                    }
                    else if (choice == "BDT" || choice == "bdt" || choice == "Bdt" || choice == "BDt")
                    {
                        Console.WriteLine("Please Enter your amount in BDT. ");
                        float taka = float.Parse(Console.ReadLine());
                        float doller = taka / 116f;
                        Console.WriteLine("The amount is USD Doller is " + doller.ToString("0.00"));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Key Press. Please Press Right key.");
                    }
                }
                else if (answer == "T" || answer == "t")
                {
                    Console.WriteLine("Please enter 'C' to convert from Celsius Or 'F' for Fahrenheit");
                    string Answer = Console.ReadLine();
                    if (Answer == "C" || Answer == "c")
                    {
                        Console.WriteLine("Enter your Temperature in Celsius.");
                        float celcuis = float.Parse(Console.ReadLine());
                        float fahrenheit = celcuis * 1.18f + 32f;
                        Console.WriteLine("The Temperature in Fahrenheit: " + fahrenheit);
                    }
                    else if (Answer == "f" || Answer == "F")
                    {
                        Console.WriteLine("Enter your Temperature in Fahrenheit.");
                        float fahrenheit = float.Parse(Console.ReadLine());
                        float celcuis = (fahrenheit - 32f) / 1.18f;
                        Console.WriteLine("The Temperature in Celcuis: " + celcuis);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Key Press. Please Press Right key.");
                }
                Console.WriteLine("Thank You ! Have a nice day!");
        }
    }
}
