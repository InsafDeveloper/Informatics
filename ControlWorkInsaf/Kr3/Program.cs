using System;
using static System.Console;

namespace Kr3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Write("Введите N для Фибоначчи ");
         
            Write(Fibonachi(Int32.Parse(ReadLine())));
        }
        
        private static int Fibonachi(int n)
        {
            return n == 0 || n == 1 ? n : Fibonachi(n - 1) + Fibonachi(n - 2);
        }
    }
    
    
}