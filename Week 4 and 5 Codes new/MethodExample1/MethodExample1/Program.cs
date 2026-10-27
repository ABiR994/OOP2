using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;

            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter third number: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            double total = CalculateSum(num1, num2, num3);
            double average = CalculateAverage(total);
            double maximum = FindMaximum(num1, num2, num3);
            double minimum = FindMinimum(num1, num2, num3);

            Console.WriteLine("\n----- Result -----");
            Console.WriteLine("Sum = " + total);
            Console.WriteLine("Average = " + average);
            Console.WriteLine("Maximum = " + maximum);
            Console.WriteLine("Minimum = " + minimum);

            Console.ReadKey();
        }

        static double CalculateSum(double a, double b, double c)
        {
            return a + b + c;
        }

        static double CalculateAverage(double sum)
        {
            return sum / 3;
        }

        static double FindMaximum(double a, double b, double c)
        {
            double max = a;

            if (b > max)
                max = b;

            if (c > max)
                max = c;

            return max;
        }

        static double FindMinimum(double a, double b, double c)
        {
            double min = a;

            if (b < min)
                min = b;

            if (c < min)
                min = c;

            return min;
        }
    }
}
