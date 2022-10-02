using System;
using System.ComponentModel.DataAnnotations;

namespace lab3
{
    class Program
    {
        static int Main(string[] args) //12 variant
        {
            int input = 0;
            string strInput = "";
            Console.WriteLine("Input - ");
            strInput = Console.ReadLine();

            try
            {
                int.Parse(strInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error - input is not number");
                return -1;
            }

            if (strInput.Length != 3)
            {
                Console.WriteLine("Error - input is not three-digit");
                return -2;
            }

            if (strInput[0] != strInput[1] && strInput[1] != strInput[2] && strInput[0] != strInput[2])
            {
                Console.WriteLine("TRUE - this three-digit number has uniq digits");
            }
            else
            {
                Console.WriteLine("FALSE - this three-digit number has not uniq digits");
            }
            return 0;
        }
    }
}