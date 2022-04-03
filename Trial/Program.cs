using System;

namespace Trial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Your Surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(PrintName(name,surname));
        }

        static string PrintName(string name, string surname)
        {
            string fullName = name +" "+ surname;
            return fullName;
        }
    }
}
