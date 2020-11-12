using System;
using System.Collections.Generic;
using System.Linq;
//r
namespace MostReadNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> massiveOfNumbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
            massiveOfNumbers.Sort();
            if (massiveOfNumbers.Count > 1)
            {
                int mostNumber = massiveOfNumbers[1];
                int amountOfMostNumber = 1;
                int maxAmountOfMostNumber = 1;
                for (int i = 1; i < massiveOfNumbers.Count; i++)
                {
                    if (massiveOfNumbers[i] == massiveOfNumbers[i - 1])
                    {
                        amountOfMostNumber += 1;
                    }
                    else
                    {
                        amountOfMostNumber = 1;
                    }

                    if (amountOfMostNumber > maxAmountOfMostNumber)
                    {
                        mostNumber = massiveOfNumbers[i];
                        maxAmountOfMostNumber = amountOfMostNumber;
                    }
                }

                if (maxAmountOfMostNumber == 1)
                {
                    Console.WriteLine("Все элементы уникальны");
                }
                else Console.WriteLine($"Чаще всего встречается {mostNumber}");
            }
            else
            {
                Console.WriteLine($"Чаще всего встречается {massiveOfNumbers[0]}");
            }
        }
    }
}