using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                // Declare and initialize the jagged array
                int[][] books = new int[3][];

                books[0] = new int[] { 10, 15 };
                books[1] = new int[] { 20, 25, 30 };
                books[2] = new int[] { 35, 40, 45, 50 };

                // Display the elements row by row
                for (int i = 0; i < books.Length; i++)
                {
                    Console.Write("Shelf " + i + ": ");

                    for (int j = 0; j < books[i].Length; j++)
                    {
                        Console.Write(books[i][j] + " ");
                    }

                    Console.WriteLine();
                }

                Console.ReadKey();
            }
        }
    }
}
   
