using System;

namespace Circle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int radius = int.Parse(Console.ReadLine());
            for (int y = radius; y > -radius - 1; y = y -1)
            {
                for (int x = -radius; x < radius + 1; x++)
                {
                    if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(radius, 2)) Console.Write(".");
                    else Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
    }
}