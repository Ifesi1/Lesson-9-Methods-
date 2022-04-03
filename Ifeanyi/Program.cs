using System;

namespace Ifeanyi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello Friend, enter a number:  ");
            int[] first = {2,7,3,1,12,6,0,-3 };
            Console.WriteLine("the sorted numbers are: {0}:",SortedElements(first));
        }

        static int[] SelectionSort(int[] first)
        {
            for (int i = 0; i < first.Length-1; i++)
            {
                for (int j = i+1; j < first.Length; j++)
                {
                    if (first[i]>first[j])
                    {
                        int newVariable = first[j];
                        first[j] = first[i];
                        first[i] = newVariable;
                        Console.WriteLine(newVariable);
                    }
                }
            }
        }

        static int[] SortedElements(int[] first)
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (i < (first.Length-1))
                {
                    return SelectionSort(first);
                }
            }
        }

    }
}
