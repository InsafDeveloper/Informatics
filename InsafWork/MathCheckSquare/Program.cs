using static System.Console;
using static System.Math;

namespace MathCheckSquare
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            InputSquareData.Input();
        }
    }

    public class InputSquareData
    {
        public static void Input()
        {
            WriteLine("Введите координаты двух сторон квадрата (x0, y0 | x1, y1), разделяя их переносом строки");
            Square square = new Square(double.Parse(ReadLine()), double.Parse(ReadLine()) ,double.Parse(ReadLine()), double.Parse(ReadLine()));
            switch (SquareOperations.CheckSquareExistence(square))
            {
                case true:
                    WriteLine("Введите координаты точки, разделяя их переносом строки");
                    StartOperations(square, double.Parse(ReadLine()), double.Parse(ReadLine()));
                    break;
                case false:
                    WriteLine("Это не квадрат");
                    break;
            }
        }

        private static void StartOperations(in Square square, double dotX0, double dotY0)
        {
            switch (SquareOperations.CheckDotOwns(square, dotX0, dotY0))
            {
                case true:
                    WriteLine("Точка лежит на квадрате");
                    break;
                case false:
                    WriteLine("Точка не лежит на квадрате");
                    break;
            }
        }
    }

    sealed class SquareOperations
    {
        public static bool CheckSquareExistence(in Square square)
        {
            var deltaX = Abs(square.x0 - square.x1);
            var deltaY = Abs(square.y0 - square.y1);

            return deltaX == deltaY;
        }

        public static bool CheckDotOwns(in Square square, double dotX0, double dotY0)
        {
            return Max(square.x0, square.x1) >= dotX0 && dotX0 >= Min(square.x0, square.x1) &&
                   Max(square.y0, square.y1) >= dotY0 && dotY0 >= Min(square.y0, square.y1);
        }
    }

    struct Square
    {
        public readonly double x0;
        public readonly double y0;
        public readonly double x1;
        public readonly double y1;

        public Square(double x0, double y0, double x1, double y1)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.x1 = x1;
            this.y1 = y1;
        }
    }
}