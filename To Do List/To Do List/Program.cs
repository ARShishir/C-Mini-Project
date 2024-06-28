using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The To Do List Program");
            
            List<string> tasklist = new List<string>();
            string option = "E";

            //string taskList; 

            while (option !="E" || option != "e" )
            {

                Console.WriteLine("What Would you like to do?");
                Console.WriteLine("Enter 1 to Add a Task to the list.");
                Console.WriteLine("Enter 2 to  Remove a Task to the list.");
                Console.WriteLine("Enter 3 to  View a Task to the list.");
                Console.WriteLine("Enter E or e to  Exit the program");
             
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine();
                    string task = Console.ReadLine();
                    tasklist.Add(task);
                    Console.WriteLine("Task Added to the list.");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(i + ": " + tasklist[i]);
                    }

                    Console.WriteLine("Please Enter the number of the task to Remove form the List: ");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    tasklist.RemoveAt(taskNumber);

                }

                else if (option == "3")
                {
                    Console.WriteLine("Current Task int the List : ");
                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(tasklist[i]);

                    }
                }
                else if (option == "e" || option == "E")
                {
                    Console.WriteLine("Exiting Program");
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid Option,Please Try again");
                    continue;
                }
                

            }
            Console.WriteLine("Thank You");

        }
    }
}
