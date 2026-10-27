using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
           

            {
                int[,] numbers = new int[2, 3];

                Console.WriteLine("Enter 6 numbers:");

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("Enter value: ");
                        numbers[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nStored Values:");

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(numbers[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
    }

