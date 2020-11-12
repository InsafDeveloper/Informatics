using System;
using System.Collections;
using System.Linq;
//r
namespace ModuleBolsheMaxInM
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var massiveOfNumbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
            int maxInMassive = massiveOfNumbers.Max();
            int amount = 0;
            foreach (var number in massiveOfNumbers)
            {
                if (Math.Abs(number) > maxInMassive)
                {
                    amount += 1;
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine($"\nTotal: {amount}");
        }
    }
}