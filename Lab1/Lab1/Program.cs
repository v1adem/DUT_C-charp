using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1 = 0, t1 = 0, v2 = 0, t2 = 0;

            Console.WriteLine("Input v1 - ");
            string v1r = Console.ReadLine();
            double.TryParse(v1r, out v1);

            Console.WriteLine("Input t1 - ");
            string t1r = Console.ReadLine();
            double.TryParse(t1r, out t1);

            Console.WriteLine("Input v2 - ");
            string v2r = Console.ReadLine();
            double.TryParse(v2r, out v2);

            Console.WriteLine("Input t2 - ");
            string t2r = Console.ReadLine();
            double.TryParse(t2r, out t2);


            double t = ((v1 * t1) + (v2 * t2)) / (v1 + v2);

            Console.WriteLine($"Temperature of solution - {t}°c");
        }
    }
}
