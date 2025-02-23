using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurze
{
    internal class Program
    {
        private static int times_fac;
        private static int times_fib;
        public static int Factorial(int number)
        {
            times_fac++;
            if(number < 2)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
        public static int FibonacciRecursive(int number)
        {
            times_fib++;
            if(number<=1)
            {
                return 1;
            }
            else
            {
                return FibonacciRecursive(number - 1) + FibonacciRecursive(number - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number.");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The factorial of " + number + " is " + Factorial(number) + " and the function ran "+times_fac+" times.");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(FibonacciRecursive(i));
            }
            Console.ReadKey();
        }
    }
}
