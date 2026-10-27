//Write a program that accepts five numbers from the user and calculates their total sum and average.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            int count = 1;

            Console.WriteLine("Enter 5 Numbers");

            while (count <= 5)
            {
                Console.Write("Enter Number " + count + ": ");
                number = Convert.ToInt32(Console.ReadLine());

                sum = sum + number;
                count++;
            }

            Console.WriteLine("\nTotal Sum = " + sum);
            Console.WriteLine("Average = " + (double)sum / 5);
        }
    }
    }

