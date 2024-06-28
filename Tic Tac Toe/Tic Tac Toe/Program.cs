using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
     class Program
    {
        static void Main(string[] args)
        {
            string[] grid = new string[9] { "1", "2", " 3", "4", "5", "6", "7", "8", "9" };

            printGrid();
             
        }
    }
}


void printGrid()
{

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(grid[i + 3 + j] + "|");
        }
        Console.WriteLine();
        Console.WriteLine("------");
    }
    Console.WriteLine();

}
