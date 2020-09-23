using System;

namespace CheckForSquareAndPointInIt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите координаты x0,y0:");
            string[] x0_and_y0 = Console.ReadLine().Split(',');
            int x0 = int.Parse(x0_and_y0[0]);
            int y0 = int.Parse(x0_and_y0[1]);
            
            Console.Write("Введите координаты x1,y1:");
            string[] x1_and_y1 = Console.ReadLine().Split(',');
            int x1 = int.Parse(x1_and_y1[0]);
            int y1 = int.Parse(x1_and_y1[1]);

            if (x1 - x0 == y1 - y0)
            {
                Console.Write("Это квадрат. Введите точку для проверки в формате x,y:");
                string[] x_and_y = Console.ReadLine().Split(',');
                int x = int.Parse(x_and_y[0]);
                int y = int.Parse(x_and_y[1]);

                if (((x0 <= x && x <= x1) && (y0 <= y && y <= y1)) || ((x0 <= x && x <= x1) && (y1 <= y && y <= y0)) ||
                    ((x1 <= x && x <= x0) && (y1 <= y && y <= y0)) || ((x1 <= x && x <= x0) && (y0 <= y && y <= y1)))
                {
                    Console.WriteLine("True");
                }
                else Console.WriteLine("False");
            }
            else Console.WriteLine("Это не квадрат");
        }
    }
}