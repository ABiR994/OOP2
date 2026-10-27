using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingEx2
{
    
        class Program
        {
            // Method to add two integers
            static int Add(int a, int b)
            {
                return a + b;
            }

            // Overloaded method to add three integers
            static int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            // Overloaded method to add two double values
            static double Add(double a, double b)
            {
                return a + b;
            }

            // Overloaded method to concatenate two strings
            static string Add(string firstName, string lastName)
            {
                return firstName + " " + lastName;
            }

            static void Main(string[] args)
            {
                int sum1 = Add(10, 20);
                int sum2 = Add(15, 25, 35);
                double sum3 = Add(12.5, 8.7);
                string fullName = Add("Syeda", "Asrafa");

                Console.WriteLine("Addition of two integers: " + sum1);
                Console.WriteLine("Addition of three integers: " + sum2);
                Console.WriteLine("Addition of two double values: " + sum3);
                Console.WriteLine("Full Name: " + fullName);

                Console.ReadKey();
            }
        }
    }


