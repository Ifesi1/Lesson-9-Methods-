using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to be calculated:  ");
            int fact = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("The factorial of {0} has a value of {1}",fact, FactorialSolution(fact));
        }

        static int FactorialSolution(int fact)
        {
            int factorial = 1;
            for (int i = fact; i > 1; i--)
            {
                factorial = fact * (fact - 1);
            }
            return factorial;
        }

    }
}
