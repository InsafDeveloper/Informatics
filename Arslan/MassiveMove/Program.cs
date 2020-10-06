using System;
using System.Collections.Generic;
using System.Linq;
//r
namespace MassiveMove
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> massiveOfNumbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
            int amountOfMoves = int.Parse(Console.ReadLine());
            for (int i = 0; i < amountOfMoves; i++)
            {
                massiveOfNumbers = MassiveMove(massiveOfNumbers);
            }

            foreach (var VARIABLE in massiveOfNumbers)
            {
                Console.Write($"{VARIABLE} ");
            }
        }

        static List<int> MassiveMove(List<int> massiveOfNumbers)
        {
            int temp = massiveOfNumbers.Last();
            for (int i = massiveOfNumbers.Count - 1; i > 0; i--)
            {
                massiveOfNumbers[i] = massiveOfNumbers[i - 1];
            }
            massiveOfNumbers[0] = temp;
            return massiveOfNumbers;
        }
    }
}