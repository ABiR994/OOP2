//Write a program that takes a student's marks and displays the corresponding grade and result status.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExample
{
    class Program
    {
        static void Main(string[] args)
        {
     
            {
                string studentName;
                int marks;

                Console.Write("Enter Student Name: ");
                studentName = Console.ReadLine();

                Console.Write("Enter Marks (0-100): ");
                marks = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n----- Result -----");
                Console.WriteLine("Student Name: " + studentName);
                Console.WriteLine("Marks: " + marks);

                if (marks >= 80)
                {
                    Console.WriteLine("Grade: A+");
                    Console.WriteLine("Status: Excellent");
                }
                else if (marks >= 70)
                {
                    Console.WriteLine("Grade: A");
                    Console.WriteLine("Status: Very Good");
                }
                else if (marks >= 60)
                {
                    Console.WriteLine("Grade: B");
                    Console.WriteLine("Status: Good");
                }
                else if (marks >= 50)
                {
                    Console.WriteLine("Grade: C");
                    Console.WriteLine("Status: Pass");
                }
                else
                {
                    Console.WriteLine("Grade: F");
                    Console.WriteLine("Status: Fail");
                }
            }
        }
    }
    }

