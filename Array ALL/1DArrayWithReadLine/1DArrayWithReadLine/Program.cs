using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DArrayWithReadLine
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int[] marks = new int[5];
                int total = 0;

                for (int i = 0; i < marks.Length; i++)
                {
                    Console.Write("Enter marks for Student " + (i + 1) + ": ");
                    marks[i] = Convert.ToInt32(Console.ReadLine());

                    total += marks[i];
                }

                double average = (double)total / marks.Length;

                Console.WriteLine("\nMarks Entered:");

                foreach (int mark in marks)
                {
                    Console.WriteLine(mark);
                }

                Console.WriteLine("\nTotal Marks = " + total);
                Console.WriteLine("Average Marks = " + average);
            }
        }
    }
}
