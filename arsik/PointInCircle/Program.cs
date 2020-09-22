using System;

namespace PointInCircle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите координаты центра круга в формате x,y:");
            string[] x0_and_y0 = Console.ReadLine().Split(',');
            int x0 = int.Parse(x0_and_y0[0]);
            int y0 = int.Parse(x0_and_y0[1]);
            
            Console.Write("\nВведите радиус:");
            int radius = int.Parse(Console.ReadLine());
            
            Console.Write("\nВведите точку для проверки в формате x,y:");
            string[] x_and_y = Console.ReadLine().Split(',');
            int x = int.Parse(x_and_y[0]);
            int y = int.Parse(x_and_y[1]);
            
            if (Math.Pow(x-x0, 2) + Math.Pow(y-y0, 2) <= Math.Pow(radius, 2)) Console.WriteLine("\nTrue");
            else Console.Write("\nFalse");
        }
    }
}