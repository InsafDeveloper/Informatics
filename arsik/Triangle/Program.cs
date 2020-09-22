using System;

namespace Triangle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите длину 1-й стороны:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите длину 2-й стороны:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите длину 3-й стороны:");
            double c = double.Parse(Console.ReadLine());

            int operation = 6;
            if (CheckForTriangle(a, b, c))
            {
                Console.WriteLine("\nЭто треугольник!\n");
                
                double[] angles = FindAngles(a,b,c);
                double square = FindASquare(a, c, angles[0]);
                PrintOperations();
                
                while (operation != 0)
                {
                    operation = int.Parse(Console.ReadLine());
                    switch (operation)
                    {
                        case 1:
                            PrintOutAngles(angles);
                            Console.WriteLine($"\nЭто {DefineType(angles)} треугольник.");
                            break;
                        case 2:
                            Console.WriteLine($"\nПлощадь: {square}.");
                            break;
                        case 3:
                            Console.WriteLine($"\nНаименьшая высота: {FindHeights(a, b, c, square)[0]}\nНаибольшая высота: {FindHeights(a, b, c, square)[1]}");
                            break;
                        case 4:
                            Console.WriteLine($"\nПлощадь вписанного круга: {FindASquareOfBall((a+b+c)/2, square)}");
                            break;
                        case 5:
                            PrintOutAngles(angles);
                            Console.WriteLine($"\nЭто {DefineType(angles)} треугольник.");
                            Console.WriteLine($"\nПлощадь: {square}.");
                            Console.WriteLine($"\nНаименьшая высота: {FindHeights(a, b, c, square)[0]}\nНаибольшая высота: {FindHeights(a, b, c, square)[1]}");
                            Console.WriteLine($"\nПлощадь вписанного круга: {FindASquareOfBall((a+b+c)/2, square)}");
                            operation = 0;
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Неверный номер :(");
                            break;
                    }
                }
            }
            else Console.WriteLine("\nЭто не треугольник :(");
        }

        static bool CheckForTriangle(double a, double b, double c)
        {
            if (a + b > c && b + c > a && a + c > b) return true;
            else return false;
        }

        static double[] FindAngles(double a, double b, double c)
        {
            // a_angle между a c, b_angle a b, c_angle b c
            double a_angle = Math.Acos((a * a + c * c - b * b) / (2 * a * c));
            double b_angle = Math.Acos((a * a + b * b - c * c) / (2 * a * b));
            double c_angle = Math.Acos((b * b + c * c - a * a) / (2 * b * c));
            double[] Angles = new [] {a_angle, b_angle, c_angle};
            return Angles;
        }

        static void PrintOutAngles(double[] Angles)
        {
            for (int i = 0; i<Angles.Length;i++) Console.WriteLine($"{i+1}-й угол равен {Math.Round(Angles[i] * 57.2958)} градусов.");
        }

        static string DefineType(double[] Angles)
        {
            if (Math.Round(Angles[0] * 57.2958) < 90 && Math.Round(Angles[1] * 57.2958) < 90 && Math.Round(Angles[2] * 57.2958) < 90)
            {
                return "остроугольный";
            }
            else if (Math.Round(Angles[0] * 57.2958) == 90 || Math.Round(Angles[1] * 57.2958) == 90 || Math.Round(Angles[2] * 57.2958) == 90)
            {
                return "прямоугольный";
            }
            else
            {
                return "тупоугольный";
            }
        }

        static double FindASquare(double a, double c, double a_angle)
        {
            return (Math.Sin(a_angle) * a * c) / 2;
        }

        static double[] FindHeights(double a, double b, double c, double S)
        {
            double maxi = Math.Max(Math.Max(a, b), c);
            double mini = Math.Min(Math.Min(a, b), c);
            return new[] {(S*2)/maxi,(S*2)/mini};
        }

        static double FindASquareOfBall(double half_of_perimeter, double square)
        {
            return Math.PI * Math.Pow(square / half_of_perimeter, 2);
        }

        static void PrintOperations()
        {
            Console.WriteLine("Введите номер нужной вам операции:");
            Console.WriteLine("1. Найти углы и определить тип треугольника");
            Console.WriteLine("2. Найти площадь треугольника");
            Console.WriteLine("3. Найти наибольшую и наименьшую высоту треугольника");
            Console.WriteLine("4. Найти плошадь вписанного в этот треугольник круга");
            Console.WriteLine("5. Выполнить все операции");
            Console.WriteLine("0. Прекратить выполнение программы");
        }
    }
}