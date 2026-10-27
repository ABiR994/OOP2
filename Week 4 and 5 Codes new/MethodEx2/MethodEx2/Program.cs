using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodEx2
{
    class Program
    {
        // Method with one parameter
        static void DisplayStudent(string name)
        {
            Console.WriteLine("Student Name: " + name);
        }

        // Method with two parameters
        static void DisplayCourse(string courseName, int credit)
        {
            Console.WriteLine("Course: " + courseName);
            Console.WriteLine("Credit Hours: " + credit);
        }

        // Method with three parameters
        static void DisplayResult(string name, double marks, string grade)
        {
            Console.WriteLine("\nStudent: " + name);
            Console.WriteLine("Marks: " + marks);
            Console.WriteLine("Grade: " + grade);
        }

        // Method with return value
        static double CalculateAverage(double mark1, double mark2, double mark3)
        {
            return (mark1 + mark2 + mark3) / 3;
        }

        // Method with return value
        static string GetGrade(double average)
        {
            if (average >= 80)
                return "A+";
            else if (average >= 70)
                return "A";
            else if (average >= 60)
                return "A-";
            else if (average >= 50)
                return "B";
            else
                return "F";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("===== Student Information System =====\n");

            DisplayStudent("Alice");
            DisplayCourse("Object Oriented Programming", 3);

            double avg1 = CalculateAverage(85, 90, 88);
            string grade1 = GetGrade(avg1);
            DisplayResult("Alice", avg1, grade1);

            Console.WriteLine();

            DisplayStudent("Bob");
            DisplayCourse("Data Structures", 3);

            double avg2 = CalculateAverage(72, 68, 75);
            string grade2 = GetGrade(avg2);
            DisplayResult("Bob", avg2, grade2);

            Console.WriteLine();

            DisplayStudent("Charlie");
            DisplayCourse("Database Systems", 3);

            double avg3 = CalculateAverage(58, 62, 60);
            string grade3 = GetGrade(avg3);
            DisplayResult("Charlie", avg3, grade3);

            Console.WriteLine("\nProgram Finished.");

            Console.ReadKey();
        }
    }
}
