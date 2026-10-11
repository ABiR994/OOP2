using System;

namespace introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your monthly salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Current Age: " + age);
            Console.WriteLine("Age After 5 Years: " + (age + 5));
            Console.WriteLine("Monthly Salary: " + salary);
            Console.WriteLine("Salary After Type Casting: " + (int)salary);
        }
    }
}