using System;
using static System.Console;

namespace MathNotation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Введите число в десятичной системе и систему в которую хотите перевести");
            WriteLine(Convert.ToString(Int32.Parse(ReadLine()), Int32.Parse(ReadLine())));
        }
    }

    
}