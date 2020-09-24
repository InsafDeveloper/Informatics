using System;
using static System.Console;
using static System.Random;

namespace MathTriforce
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Write("Введите высоту треугольника: ");
            Triforce triforce = new Triforce(Int32.Parse(ReadLine()));

            PrintMatrix(in triforce);
        }

        static void PrintMatrix(in Triforce triforce)
        {
            for (int i = 0; i < triforce.Height * 2; i++)
            {
                for (int j = 0; j < triforce.TriforceMatrix.GetLength(1); j++)
                {
                    ForegroundColor = (ConsoleColor) new Random().Next(16);
                    Write(triforce.TriforceMatrix[i, j]);
                }
                WriteLine();
            }
        }
    }

    class Triforce
    {
        public readonly int Height;
        public readonly char[,] TriforceMatrix;
        
        public Triforce(int height)
        {
            Height = height;

            TriforceMatrix = DrawTriforce();
        }

        private char[,] DrawTriforce()
        {
            char[,] triforceMatrix = new char[Height * 2, ((Height - 1) * 2 + 1) * 2 + 1];
            DrawTriangle(ref triforceMatrix);
            EraseTriangle(ref triforceMatrix);

            return triforceMatrix;
        }

        private void DrawTriangle(ref char[,] triforceMatrix)
        {
            for (int i = 0; i < Height * 2; i++)
            {
                int blankCharLength = (triforceMatrix.GetLength(1) - (i * 2 + 1));
                blankCharLength /= 2;
                int charLength = triforceMatrix.GetLength(1) - blankCharLength * 2;
                for (int j = 0; j <= triforceMatrix.GetLength(1) / 2; j++)
                {
                    if (blankCharLength != 0)
                    {
                        triforceMatrix[i, j] = ' ';
                        triforceMatrix[i, triforceMatrix.GetLength(1) - j - 1] = ' ';
                        blankCharLength--;
                    }
                    else if (charLength != 0)
                    {
                        ForegroundColor = (ConsoleColor) new Random().Next(16);
                        triforceMatrix[i, j] = '*';
                        triforceMatrix[i, triforceMatrix.GetLength(1) - j - 1] = '*';
                        charLength--;
                    }
                }
            }
        }

        private void EraseTriangle(ref char[,] triforceMatrix)
        {
            int eraseLength = 1;
            int stepToMiddle = triforceMatrix.GetLength(1) / 2 - 1;

            for (int i = Height * 2 - 1; i >= Height; i--)
            {
                stepToMiddle = triforceMatrix.GetLength(1) / 2 - (Height * 2 - i);
                eraseLength = (Height * 2 - 1 - i) * 2 + 1;
                while (eraseLength != 0)
                {
                    stepToMiddle++;
                    triforceMatrix[i, stepToMiddle] = ' ';
                    eraseLength--;
                }
            }
        }
    }
    
}