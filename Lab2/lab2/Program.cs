using System;
using System.Reflection;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nk = -1;
            while (nk < 0)
            {
                Console.WriteLine("Input NK - ");
                string strNK = Console.ReadLine();
                int.TryParse(strNK, out nk);
                if (nk < 0) Console.WriteLine("Error nk < 0");
            }

            int nn = -1;
            while (nn < 0)
            {
                Console.WriteLine("Input NN - ");
                string strNN = Console.ReadLine();
                int.TryParse(strNN, out nn);
                if (nn < 0) Console.WriteLine("Error nn < 0");
                if (nk < nn) Console.WriteLine("Erroe nn > nk");
            }

            double result = 0;
            while (nn <= nk)
            {
                result += (3 * nn + Math.Pow(-1, (Math.Pow(nn, 2) - nn + 1) * nn)) / (2 * Math.Pow(nn, 2) + 1);
                nn++;
            }

            Console.WriteLine($"Result : {result}");
            

            
        }
    }
}