using System;
using static System.Console;
using static System.Math;

namespace Cr2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = Int32.Parse(ReadLine());
            int m = Int32.Parse(ReadLine());
            int[,]arr = new int[n,m];
            
            
            for (int i = 0; i < n; i++)
            {
                arr[i, 0] = GetUniqueNumber(arr, n, m, "str");
            }
            for (int i = 1; i < m; i++)
            {
                arr[0, i] = GetUniqueNumber(arr, n, m, "stolb");
            }
            
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    arr[i, j] = Min(Min(arr[i, j - 1], arr[i - 1, j]), Min(arr[i - 1, j], arr[i - 1, j - 1])) + 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Write(arr[i, j] + " ");
                }
                WriteLine();
            }
            
            WriteLine(arr[n-1,m-1]);
        }
        
        private static int GetUniqueNumber(int[,] array, int n, int m, string type)
        {
            Random random = new Random();
            int number = 0;
            if (type == "str")
            {
                number = random.Next(1, n + 1);
                while (!CheckForUnique(array, n, m, number, type))
                {
                    number = random.Next(1, n + 1);
                }
            }
            else
            {
                number = random.Next(1, m + 1);
                while (!CheckForUnique(array, n, m, number, type))
                {
                    number = random.Next(1, m + 1);
                }
            }

            return number;
        }
        
        private static bool CheckForUnique(int[,] array, int n, int m, int number, string type)
        {
            if (type == "str")
            {
                for (int i = 0; i < n; i++)
                {
                    if (array[i, 0] == number)
                        return false;
                }
            }

            if (type == "stolb")
            {
                for (int i = 0; i < m; i++)
                {
                    if (array[0, i] == number)
                        return false;
                }
            }

            return true;
        }

    }
}