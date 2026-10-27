using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dArrayWithoutUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            
                // Declare and initialize a 1D array
                int[] marks = { 85, 78, 92, 88, 76 };

                int total = 0;

                Console.WriteLine("Student Marks:");
                Console.WriteLine("----------------");

        
                for (int i = 0; i < marks.Length; i++)
                {
                    Console.WriteLine("Student " + (i + 1) + ": " + marks[i]);
                    total += marks[i];
                }

                
                double average = (double)total / marks.Length;

                Console.WriteLine("----------------");
                Console.WriteLine("Total Marks = " + total);
                Console.WriteLine("Average Marks = " + average);
            Console.ReadKey();
            }
        }
    }
    
