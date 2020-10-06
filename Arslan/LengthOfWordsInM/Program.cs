using System;
//r
namespace LengthOfWordsInM
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] massiveOfWords = Console.ReadLine().Split(' ');
            int minLength = int.Parse(Console.ReadLine());
            foreach (var word in massiveOfWords)
            {
                if(word.Length > minLength) Console.WriteLine(word);
            }
        }
    }
}