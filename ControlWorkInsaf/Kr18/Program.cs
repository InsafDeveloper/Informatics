using System;
using static System.Console;

namespace Kr18
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Write("Введите длину для конвертации (в кабельтах): ");

            double K = Double.Parse(ReadLine());

            var f = K * Izmereniya.Kabelt / Izmereniya.furlong;
            if (f < 0 || K < 0)
                WriteLine("Числа должны быть положительными!");
            else
            {
                WriteLine(K + " кабельтов это: " + f + " фурлонгов");
                WriteLine(f + " фурлонгов это: " + f * Izmereniya.furlong + " метров");
            }
        }
    }


    static class Izmereniya
    {
        public const float Kabelt = 182.88f; // meters
        public const float furlong = 201.16f; //meters
        
    }
}