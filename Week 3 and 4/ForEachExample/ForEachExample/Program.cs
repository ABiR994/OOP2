//Write a program that stores student names and marks in arrays and displays each student's information along with pass/fail status using a foreach loop.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentNames =
        {
            "Rahim",
            "Karim",
            "Nadia",
            "Sadia",
            "Hasan"
        };

            int[] marks =
            {
            85,
            72,
            90,
            65,
            45
        };

            int index = 0;

            Console.WriteLine("Student Information");
            Console.WriteLine("-------------------");

            foreach (string student in studentNames)
            {
                Console.WriteLine("Student Name : " + student);
                Console.WriteLine("Marks        : " + marks[index]);

                if (marks[index] >= 50)
                {
                    Console.WriteLine("Result       : Pass");
                }
                else
                {
                    Console.WriteLine("Result       : Fail");
                }

                Console.WriteLine();
                index++;
            }
        }
    }
}
