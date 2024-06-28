using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Area_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

        string answer;
        float result = 0;
        Console.WriteLine("What shape would you like to find the area of ? please Enter 'R' dor Rectangle and 'C' for Circle.");
        answer = Console.ReadLine();
            if (answer == "r" || answer == "R")
            {
                Console.WriteLine("Please Enter the height of the Rectangle.");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter the width of the rectangle");
                float width = float.Parse(Console.ReadLine());                 
                result = height * width;
            }
            else if (answer == "c" || answer == "C") 
            {
                Console.WriteLine("please enter the radius of the circle.");
                float radius = float.Parse(Console.ReadLine());
                result = (float)Math.PI * (radius * radius);            
            }
            else
            {
                Console.WriteLine("Enter the Right key");
            }
        Console.WriteLine("The result is : " + result);
        Console.ReadKey();
        }
    }
}
