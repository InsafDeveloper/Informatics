using System;
using System.Linq;
using static System.Console;
using static System.Math;

namespace MathEquationSolver
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Calculate("1000.1 1.2 1"));
        }
        public static double Calculate(string userInput)
        {
            string[] str_line = userInput.Split(' ');
            double sum = Convert.ToDouble(str_line[0].Replace('.',','));
            double percent = (Convert.ToDouble(str_line[1].Replace('.',',')));
            int months = Int32.Parse(str_line[2]);

            return sum * Math.Pow(1 + percent/1200,months);
        }

        
        
        
        
    }
}