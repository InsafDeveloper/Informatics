using System;
using System.Collections.Generic;
using System.Linq;

namespace MedianaOfMassive
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> massiveOfNumbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
            if (massiveOfNumbers.Count % 2 == 0) Console.WriteLine(massiveOfNumbers.Sum()/Convert.ToDouble(massiveOfNumbers.Count));
            else Console.WriteLine(massiveOfNumbers[massiveOfNumbers.Count/2]);
        }
    }
}