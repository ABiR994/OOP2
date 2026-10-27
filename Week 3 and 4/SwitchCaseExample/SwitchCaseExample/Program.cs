using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("===== University Course Selection System =====");
                Console.WriteLine("1. Data Structures");
                Console.WriteLine("2. Database Systems");
                Console.WriteLine("3. Artificial Intelligence");
                Console.WriteLine("4. Software Engineering");
                Console.WriteLine("5. Computer Networks");

                Console.Write("\nEnter course number (1-5): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nCourse: Data Structures");
                        Console.WriteLine("Credit Hours: 3");
                        Console.WriteLine("Prerequisite: Introduction to Programming");
                        break;

                    case 2:
                        Console.WriteLine("\nCourse: Database Systems");
                        Console.WriteLine("Credit Hours: 3");
                        Console.WriteLine("Prerequisite: Programming Fundamentals");
                        break;

                    case 3:
                        Console.WriteLine("\nCourse: Artificial Intelligence");
                        Console.WriteLine("Credit Hours: 3");
                        Console.WriteLine("Prerequisite: Data Structures");
                        break;

                    case 4:
                        Console.WriteLine("\nCourse: Software Engineering");
                        Console.WriteLine("Credit Hours: 3");
                        Console.WriteLine("Prerequisite: Object-Oriented Programming");
                        break;

                    case 5:
                        Console.WriteLine("\nCourse: Computer Networks");
                        Console.WriteLine("Credit Hours: 3");
                        Console.WriteLine("Prerequisite: Operating Systems");
                        break;

                    default:
                        Console.WriteLine("\nInvalid course selection!");
                        break;
                }

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
    

