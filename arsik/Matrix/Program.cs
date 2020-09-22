using System;

namespace Матрицы
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[][] matrix_first = GetMatrix(1);
            int[][] matrix_second = GetMatrix(2);
            switch (GetOperation())
            {
                case 1:
                    
                    if (CheckForMatrixSumAbility(matrix_first, matrix_second))
                    {
                        PrintOutEndMatrix(GetMatrixSum(matrix_first, matrix_second));
                    }
                    else
                    {
                        Console.WriteLine("Невозможно сложить подобные матрицы!");
                    }
                    
                    break;
                case 2:
                    
                    if (CheckForMatrixesMultiplicationAbility(matrix_first, matrix_second))
                    {
                        PrintOutEndMatrix(GetMatrixesMultiplication(matrix_first, matrix_second));
                    }
                    else
                    {
                        Console.WriteLine("Невозможно умножить подобные матрицы!");
                    }

                    break;
                case 3:
                    Console.Write("Введите n: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Write("С какой матрицей желаете провести операцию? (1 или 2): ");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            PrintOutEndMatrix(GetMatrixMultiByNumber(n, matrix_first));
                            break;
                        case 2:
                            PrintOutEndMatrix(GetMatrixMultiByNumber(n, matrix_second));
                            break;
                        default:
                            Console.WriteLine("Matrix под таким номером не существует!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Операции под таким номером не существует!");
                    break;
            }
        }
        static int[][] GetMatrix(int number_of_matrix)
        {
            Console.Write($"Введите количество строк {number_of_matrix}-й матрицы:");
            int amount_of_lines = int.Parse(Console.ReadLine());
            Console.Write($"Введите количество столбцов {number_of_matrix}-й матрицы:");
            int amount_of_columns = int.Parse(Console.ReadLine());

            return ConvertLinesToMatrix(amount_of_lines, amount_of_columns);
        }
        static int[][] ConvertLinesToMatrix(int amount_of_lines, int amount_of_columns)
        {
            int[][] matrix = new int[amount_of_lines][];
            Console.WriteLine("\nВводите элементы по строкам:");
            
            for (int i = 0; i < amount_of_lines; i++)
            {
                string[] str_line = Console.ReadLine().Split(' ');
                int[] int_line = new int[amount_of_columns];
                for (int j = 0; j < amount_of_columns; j++)
                {
                    int_line[j] = int.Parse(str_line[j]);
                }

                matrix[i] = int_line;
            }
            Console.Write("\n");
            return matrix;
        }
        static int GetOperation()
        {
            Console.WriteLine("Введите номер операции, которую хотите провести:\n1. Сложение матриц.\n2. Умножение матриц.\n3. Умножение матрицы на n.");
            return int.Parse(Console.ReadLine());
        }
        static bool CheckForMatrixSumAbility(int[][] matrix_first, int[][] matrix_second)
        {
            if (matrix_first.Length == matrix_second.Length)
            {
                for (int i = 0; i < matrix_first.Length; i++)
                {
                    if (matrix_first[i].Length != matrix_second[i].Length)
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }
        static int[][] GetMatrixSum(int[][] matrix_first, int[][] matrix_second)
        {
            int[][] MatrixSumResult = new int[matrix_first.Length][];
            int[] MatrixSumResultLine = new int[matrix_first[0].Length];
            
            for (int i = 0; i < matrix_first.Length; i++)
            {
                for (int j = 0; j < matrix_first[i].Length; j++)
                {
                    MatrixSumResultLine[j] = matrix_first[i][j] + matrix_second[i][j];
                }

                MatrixSumResult[i] = MatrixSumResultLine;
                MatrixSumResultLine = new int[matrix_first[0].Length];
            }

            return MatrixSumResult;
        }
        static bool CheckForMatrixesMultiplicationAbility(int[][] matrix_first, int[][] matrix_second)
        {
            if (matrix_first[0].Length == matrix_second.Length)
            {
                return true;
            }

            return false;
        }
        static int[][] GetMatrixesMultiplication(int[][] matrix_first, int[][] matrix_second)
        {
            int[][] end_matrix = new int[matrix_first.Length][];
            int[] MatrixMultiplicationResultLine = new int[matrix_second[0].Length];
            int el_sum = 0;
            
            for (int i = 0; i < matrix_first.Length; i++)
            {
                for (int j = 0; j < matrix_second[0].Length; j++)
                {
                    for (int k = 0; k < matrix_first[i].Length; k++)
                    {
                        el_sum += matrix_first[i][k] * matrix_second[k][j];
                    }

                    MatrixMultiplicationResultLine[j] = el_sum;
                    el_sum = 0;
                }

                end_matrix[i] = MatrixMultiplicationResultLine;
                MatrixMultiplicationResultLine = new int[matrix_second[0].Length];
            }

            return end_matrix;
        }
        static int[][] GetMatrixMultiByNumber(int n, int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] *= n;
                }
            }

            return matrix;
        } 
        static void PrintOutEndMatrix(int[][] matrix)
        {
            Console.WriteLine("\nПолученная матрица:");
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}