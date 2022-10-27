using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace lab4
{
    class Program
    {

        static void matrixOut(int[,] mat, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[] getColumn(int[,] mat, int n, int x)
        {
            int[] array = new int[x];
            for (int i = 0; i < x; i++)
            {
                array[i] = mat[i, n];
            }
            Array.Sort(array);
            return array;
        }
        static int[] getLine(int[,] mat, int m, int x)
        {
            int[] array = new int[x];
            for (int i = 0; i < x; i++)
            {
                array[i] = mat[m, i];
            }
            Array.Sort(array);
            return array;
        }

        static int Main(string[] args) //12 variant
        {
            int n = 10, m = 10;
            int[,] matrix = new int[m, n];

            Random rnd = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(10);
                }
            }

            matrixOut(matrix, m, n);

            //lines
            int maxInLinesFirst = 0, maxInLinesLast = 0;
            int max = 10;
            int x = m;
            for (int i = 0; i < m; i++)
            {
                int next = getLine(matrix, i, x).Distinct().Count();
                if (next < max)
                {
                    maxInLinesFirst = i + 1;
                    maxInLinesLast = i + 1;
                    max = next;
                }
                else if (next == max)
                {
                    maxInLinesLast = i + 1;
                }
            }
            Console.WriteLine("first (line) - " + maxInLinesFirst + "  last (line) - " + maxInLinesLast);

            //columns
            int maxInColumnFirst = 0, maxInColumnLast = 0;
            max = 10;
            for (int i = 0; i < m; i++)
            {
                int next = getColumn(matrix, i, x).Distinct().Count();
                if (next < max)
                {
                    maxInColumnFirst = i + 1;
                    maxInColumnLast = i + 1;
                    max = next;
                }
                else if (next == max)
                {
                    maxInColumnLast = i + 1;
                }
            }
            Console.WriteLine("first (column) - " + maxInColumnFirst + "  last (cloumn) - " + maxInColumnLast);

            return 0;
        }
    }
}
