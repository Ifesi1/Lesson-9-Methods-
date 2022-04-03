using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfValue(10);
            int number = 10;
            Console.WriteLine("Hello World!", + SumOfValue());
        }

        static double SumOfValue(double number)
        {
            Console.WriteLine(number);
            if (number == 0)
                return 0;
            else
            {
                    double sum = number + SumOfValue(number - 1);
                Console.WriteLine(sum);
            }
        }
    }
}
