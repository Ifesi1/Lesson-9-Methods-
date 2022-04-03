using System;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any word");
            //make the output of the entered word to appear as upper case
            string word = Console.ReadLine().ToUpper();

            Console.WriteLine("The number of alphabets {0} has is: {1}",word.ToUpper(),WordCounter(word));
            Console.WriteLine("Hello World!");
        }

        static int WordCounter(string word)
        {
            string[] wordMain = { word };
            int maxNumber = 0;
            if (word==" ")
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    maxNumber = i+1;
                }
            }
            return maxNumber;
        }
    }
}
