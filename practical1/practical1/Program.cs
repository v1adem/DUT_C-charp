using System;
using System.Runtime.Serialization.Formatters;

namespace bubleSortingN
{
    class bubleSorting
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(-50, 50);
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int b = array[j]; 
                        array[j] = array[j + 1]; 
                        array[j + 1] = b; 
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write(array[i]+" ");
            }

        }
        
    }
}

