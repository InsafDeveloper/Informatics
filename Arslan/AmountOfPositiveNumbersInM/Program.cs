using System;
//r
namespace AmountOfPositiveNumbersInM
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string stringOfNumbers = Console.ReadLine();
            string[] massiveOfNumbers = stringOfNumbers.Split(' ');
            int amountOfPositiveNumbers = 0;
            foreach (var number in massiveOfNumbers)
            {
                if (int.Parse(number) > 0)
                {
                    amountOfPositiveNumbers += 1;
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine($"\nTOTAL: {amountOfPositiveNumbers}");
        }
    }
}