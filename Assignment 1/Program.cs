using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the values according to the quadratic formula below");
            Console.WriteLine("a(x^2) + bx + c = 0");

            Console.Write("Enter the value for A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Enter the value for B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Enter the value for C: ");
            int C = int.Parse(Console.ReadLine());

            QuadraticFormula( A, B, C);
        }

        static void QuadraticFormula(int A, int B,int C)
        {
            int power = 2;

            int Quad = (int)Math.Pow(B, power) - (4 * A * C);
            Console.WriteLine(Quad);

            if (Quad > 0)
            {
                Console.Write(" This is a Real Root");
            }
            else if (Quad < 0)
            {
                Console.Write(" This is an Unreal Root");
            }
            else
            {
                Console.WriteLine(" The Roots are Equal");
            }
        }
    }
}
