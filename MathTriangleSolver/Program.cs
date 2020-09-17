using System;
using System.Diagnostics;
using static System.Math;
using static System.Console;
using static System.Array;

namespace MathTriangleSolver
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TriangleOperations.StartOperations();
        }
    }
    
    sealed class TriangleOperations
    {
        public static void StartOperations()
        {
            WriteLine("Введите стороны треугольника. Вводите каждый элемент в новую строку");
            
            Triangle triangle = new Triangle(Double.Parse(ReadLine()), Double.Parse(ReadLine()), Double.Parse(ReadLine()));

            string operations =
                "Введите номер команды: \n 1. Определить является ли треугольник треугольником \n 2. Найти углы треугольника и определить его тип \n 3. Найти площадь треугольника " +
                "\n 4. Найти наибольшую и наименьшую высоту треугольника \n 5. Найти площадь вписанного в этот треугольник круга \n 6. Провести все операции \n";
            
            while (true)
            {
                Write(operations);
                switch (Int32.Parse(ReadLine()))
                {
                    case 1:
                        WriteLine(CheckTriangleExistence(in triangle));
                        break;
                    case 2:
                        WriteLine(GetTriangleType(in triangle));
                         break;
                    case 3:
                        WriteLine("Площадь равна " + GetTriangleArea(in triangle));
                        break;
                    case 4:
                        WriteLine(GetTriangleHeights(in triangle));
                        break;
                    case 5:
                        WriteLine(GetInscribedCircleArea(in triangle));
                        break;
                    case 6:
                        WriteLine(CheckTriangleExistence(in triangle));
                        WriteLine(GetTriangleType(in triangle));
                        WriteLine("Площадь равна " + GetTriangleArea(in triangle));
                        WriteLine(GetTriangleHeights(in triangle));
                        WriteLine(GetInscribedCircleArea(in triangle));
                        WriteLine();
                        break;
                }
            }
        }
        
        private static string CheckTriangleExistence(in Triangle triangle)
        {
            return triangle.SideA + triangle.SideB > triangle.SideC ? "Является треугольником" : "Не является треугольником";
        }

        private static string GetTriangleType(in Triangle triangle)
        {
            string angles = triangle.AngleAB + " " + triangle.AngleBC + " " + triangle.AngleCA;
            if (Pow(triangle.SideA, 2) + Pow(triangle.SideB, 2) == Pow(triangle.SideC, 2)) return  "Прямоугольный и углы равны: " + angles;
            if (triangle.AngleAB < 90 && triangle.AngleBC < 90 && triangle.AngleCA < 90) return "Остроугольный и углы равны: " + angles;
            return "Тупогольный и углы равны: " + angles;
        }

        private static double GetTriangleArea(in Triangle triangle)
        {
            double p = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;

            return Sqrt(p * (p - triangle.SideA) * (p - triangle.SideB) * (p - triangle.SideC));
        }

        
        private static string GetTriangleHeights(in Triangle triangle)
        {
            var area = GetTriangleArea(in triangle);
            
            return "Наибольшая высота равна " + area / (triangle.SideA * 0.5f) + " и наименьшая высота равна "  + area / (triangle.SideC * 0.5f);
        }

        private static string GetInscribedCircleArea(in Triangle triangle)
        {
            double p = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            
            return "Площадь вписанного круга равна " + PI * Pow(GetTriangleArea(in triangle) / p, 2);
        }
        
    }

    public readonly struct Triangle
    {
        public readonly double SideA;
        public readonly double SideB;
        public readonly double SideC;

        public readonly double AngleAB;
        public readonly double AngleBC;
        public readonly double AngleCA;
        
        public Triangle(double a, double b, double c)
        {
            double[] triangleSides = {a, b, c};

            Sort(triangleSides);

            SideA = triangleSides[0];
            SideB = triangleSides[1];
            SideC = triangleSides[2];

            
            AngleAB = Acos((Pow(SideA, 2) - Pow(SideB, 2) - Pow(SideC, 2)) / (-2 * SideB * SideC)) * 180 / PI;
            AngleBC = Acos((Pow(SideB, 2) - Pow(SideA, 2) - Pow(SideC, 2)) / (-2 * SideA * SideC)) * 180 / PI;
            AngleCA = 180 - AngleAB - AngleBC;
            
            
        }
    }

}