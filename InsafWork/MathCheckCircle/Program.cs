using System;
using System.ComponentModel;
using static System.Math;
using static System.Console;

namespace MathCheckCircle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Введите радиус круга и координаты точки (x, y) разделяя их строкой");
            CheckCircle(double.Parse(ReadLine()), double.Parse(ReadLine()), double.Parse(ReadLine()));
        }

        public static void CheckCircle(double r, double x, double y)
        {
            switch (Sqrt(Pow(x, 2) + Pow(y, 2)) <= r)
            {
                case true:
                    WriteLine("Лежит");
                    break;
                case false:
                    WriteLine("Не лежит");
                    break;
            }
        }
    }
    
}