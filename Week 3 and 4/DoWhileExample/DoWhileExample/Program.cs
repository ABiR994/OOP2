//Write a program that repeatedly asks for a username and password until the correct credentials are entered.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileExample
{
    class Program
    {
        static void Main(string[] args)
        {

            string username;
            string password;

            do
            {
                Console.Write("Enter Username: ");
                username = Console.ReadLine();

                Console.Write("Enter Password: ");
                password = Console.ReadLine();

                if (username != "admin" || password != "1234")
                {
                    Console.WriteLine("Invalid Username or Password!");
                    Console.WriteLine();
                }

            } while (username != "admin" || password != "1234");

            Console.WriteLine("\nLogin Successful!");
            Console.WriteLine("Welcome to the System.");
        }
    }
}
