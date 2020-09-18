using System;
using static System.Console;

namespace MathDrawCircle
{
    internal class Program
    {
        static void Main()
        {
            Write("Введите радиус круга: ");
            DrawCircle(Double.Parse(Console.ReadLine()));
         
        }

        public static void DrawCircle(double radius)
        {
            
            double radius_in = radius - 0.4;
            double radius_out = radius + 0.4;

            Random random = new Random();
            
            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < radius_out; x += 0.5)
                {
                    ForegroundColor = (ConsoleColor)random.Next(16);
                    double value = x * x + y * y;
                    if (value >= radius_in * radius_in && value <= radius_out * radius_out)
                        Write(".");
                    else if (value < radius_in * radius_in && value < radius_out * radius_out)
                        Write(".");
                    else
                        Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}