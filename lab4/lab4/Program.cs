using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace lab4
{
    class Program
    {

        static int alternatingPositivityNegativity(int[] array, int size)
        {
            int iteration = 1;
            if (array[0] > 0) { iteration = 0; }

            for (int i = 1; i < size; i++)
            {
                switch (iteration)
                {
                    case 0:
                        if (array[i] > 0) { Console.WriteLine((i + 1) + " is position of number breaking progresion of PosNeg"); return i; }
                        iteration = 1;
                        break;

                    case 1:
                        if (array[i] < 0) { Console.WriteLine((i + 1) + " is position of number breaking progresion of PosNeg"); return i; }
                        iteration = 0;
                        break;
                }
            }
            Console.WriteLine("Alternating positive and negative numbers is correct");
            return 0;
        }

        static int alternatingEvenOdd(int[] array, int size)
        {
            int iteration = 1;
            if (array[0]%2 == 0) { iteration = 0; }

            for (int i = 1; i < size; i++)
            {
                switch (iteration)
                {
                    case 0:
                        if (array[0] % 2 == 0) { Console.WriteLine((i + 1) + " is position of number breaking progresion of EvenOdd"); return i; }
                        iteration = 1;
                        break;

                    case 1:
                        if (array[0] % 2 != 0) { Console.WriteLine((i + 1) + " is position of number breaking progresion of EvenOdd"); return i; }
                        iteration = 0;
                        break;
                }
            }
            Console.WriteLine("Alternating even and odd numbers is correct");
            return 0;
        }

        static void arrayOut(int[]arr)
        {
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static int Main(string[] args) //12 variant
        {
            int sizeN = 0;
            Console.Write("Input N - ");
            string strN = Console.ReadLine();
            int.TryParse(strN, out sizeN);

            int[] array = new int[sizeN];
            Random rnd = new Random();
            for (int i = 0; i < sizeN; i++) 
            {
                int randomNUmber = 0;
                while (randomNUmber == 0) { randomNUmber = rnd.Next(-9, 10); }
                array[i] = randomNUmber; 
            }

            //int test = -10 % 2;
            //Console.WriteLine(test);
            arrayOut(array);
            alternatingPositivityNegativity(array, sizeN);
            alternatingEvenOdd(array, sizeN);
            return 0;
        }
    }
}