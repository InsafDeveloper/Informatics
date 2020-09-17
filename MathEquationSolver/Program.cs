using System;
using static System.Console;
using static System.Math;

namespace MathEquationSolver
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Write("Write equation: ");
            WriteLine(SolveEquationRoots.GetEquationRoots(ReadLine()));
        }

        
    }

    class SolveEquationRoots
    {
        public static string GetEquationRoots(string readLine)
        {
            var coefficients = ReadEquation.GetEquationCoefficients(readLine);
            
            return GetSolutions(CalculateDiscriminant(coefficients), coefficients);
        }
            
        private static double CalculateDiscriminant(Coefficients coefficients)
        {
            return Pow(coefficients.b, 2) - 4 * coefficients.a * coefficients.c;
        }
        private static string GetSolutions(double discriminant, Coefficients coefficients)
        {
            if (discriminant < 0)
                switch (coefficients.b)
                {
                    case 0:
                        if (coefficients.c < 0)
                            return $"x1 = {Sqrt(Abs(coefficients.c))} and x2 = {-Sqrt(Abs(coefficients.c))}";
                        goto default;
                    default:
                        return "No solutions!";
                }
            else
                switch (discriminant)
                {
                    case 0:
                        var x = (-coefficients.b) / (2 * coefficients.a);
                        return $"x = {x}";
                    default:
                        var x1 = (-coefficients.b + Sqrt(discriminant)) / (2 * coefficients.a);
                        var x2 = (-coefficients.b - Sqrt(discriminant)) / (2 * coefficients.a);
                        return $"x1 = {x1} and x2 = {x2}";
                }
        }
        
    }
    sealed class ReadEquation
    {
        public static Coefficients GetEquationCoefficients(string readLine)
        {
            Coefficients coefficients = new Coefficients();
            
            readLine = readLine.Replace(" ", string.Empty);
            readLine = readLine.Replace("x", "X");   
            
            int index = 0;
            
            GetCoefficientA(readLine, ref index, ref coefficients);
            GetOtherCoefficients(readLine, ref index, ref coefficients);
            
            return coefficients;
        }

        static void GetCoefficientA(string readLine, ref int index, ref Coefficients coefficients)
        {
            string coefficientA = "";
            
            while (readLine[index] != 'X')
            {
                coefficientA += readLine[index];
                index++;
            }
            index += 3;
            
            coefficients.a = Double.Parse(coefficientA  == "" ? coefficientA = "1" : coefficientA);
        }

        static void GetOtherCoefficients(string readLine, ref int index, ref Coefficients coefficients)
        {
            string coefficientB = "";
            string coefficientC = "";

            while (index < readLine.Length)
            {
                switch (readLine[index])
                {
                    case 'X':
                        index++;
                        coefficientB = coefficientC;
                        coefficientC = String.Empty;
                        coefficients.b = Double.Parse(coefficientB == "" ? coefficientB = "1" : coefficientB);
                        while (index < readLine.Length)
                        {
                            coefficientC += readLine[index];
                            index++;
                        }

                        break;
                    default:
                        coefficientC += readLine[index];
                        break;
                }
                index++;
            }
            coefficients.c = Double.Parse(coefficientC == "" ? coefficientC = "0" : coefficientC);
        }

    }
    struct Coefficients
    {
        public double a;
        public double b;
        public double c;
    }
}