using System;
using System.Collections.Generic;
using System.Linq;
//r
namespace SumBetweenMaxAndMinInM
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> massiveOfNumbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
            int maxInM = massiveOfNumbers.Max();
            int minInM = massiveOfNumbers.Min();
            int indexOfMaxInM = massiveOfNumbers.IndexOf(maxInM);
            int indexOfMinInM = massiveOfNumbers.IndexOf(minInM);
            if (indexOfMaxInM > indexOfMinInM) Console.WriteLine(CountSum(massiveOfNumbers, indexOfMinInM, indexOfMaxInM));
            else Console.WriteLine(CountSum(massiveOfNumbers, indexOfMaxInM, indexOfMinInM));
        }

        static int CountSum(List<int> massiveOfNumbers, int MinIndex, int MaxIndex)
        {
            int sumBetweenMaxAndMin = 0;
            if (MinIndex == MaxIndex)
            {
                return 0;
            }
            else
            {
                for (int i = MinIndex + 1; i < MaxIndex; i++)
                {
                    sumBetweenMaxAndMin += massiveOfNumbers[i];
                }

                return sumBetweenMaxAndMin;
            }
        }
    }
}