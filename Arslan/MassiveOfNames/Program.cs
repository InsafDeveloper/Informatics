using System;
using System.Diagnostics;
using System.Security.Cryptography;
//r

namespace MassiveOfNames
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] massiveOfNames = Console.ReadLine().Split(' ');
            if(massiveOfNames.Length == 1 && massiveOfNames[0] == "") Console.WriteLine("No one likes this.");
            else PrintOut(massiveOfNames);
        }

        static void PrintOut(string[] massiveOfNames)
        {
            switch (massiveOfNames.Length)
            {
                case 1:
                    Console.WriteLine($"{massiveOfNames[0]} likes this.");
                    break;
                case 2:
                    Console.WriteLine($"{massiveOfNames[0]} and {massiveOfNames[1]} like this.");
                    break;
                case 3:
                    Console.WriteLine($"{massiveOfNames[0]},{massiveOfNames[1]} and {massiveOfNames[2]} like this.");
                    break;
                default:
                    Console.WriteLine(
                        $"{massiveOfNames[0]},{massiveOfNames[1]} and {massiveOfNames.Length - 2} others like this.");
                    break;
            }
        }
    }
}