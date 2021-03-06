﻿using System;
using static System.Math;
using static System.Console;


namespace Kr28
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Write("Введите a: "  );
            double a = Double.Parse(ReadLine());
            Write("Введите b: "  );
            double b = Double.Parse(ReadLine());
            
            if (a >= b)
                WriteLine("Неверный интервал. Начальное значение должно быть меньше конечного");
            else
            {
                Write("Введите n (шаг): ");
                int n = Int32.Parse(ReadLine());
                if (n > 0)
                    WriteLine("Шаг сетки должен быть положительным и целым!!!");
                else
                    WriteLine("Ответ: " + CalculateIntegral(a, b, n));
            }
        }
        
        private static double Function(double x)
        {   
            return Cos(x);
        }
        
        private static double CalculateIntegral(double a, double b, int n)
        {
            double result, h;
            int i;
 
            h = (b-a)/n;
            result = 0;
 
            for(i = 1; i <= n; i++)
            {
                result += Function(a + h * i);
            }
            result *= h;
 
            return result;
        }
    }
}