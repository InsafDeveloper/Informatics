using System;
// ГОТОВ
namespace Capitalization
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string word = "";
                bool thefirstletter = false;
                for (int k = 0; k < words[i].Length; k++)
                {
                    if (CheckForLetter(words[i][k]) && !thefirstletter)
                    {
                        word += char.ToUpper(words[i][k]);
                        thefirstletter = true;

                    }
                    else word += words[i][k];
                }

                words[i] = word;
                Console.Write(words[i] + " ");
            }
        }

        static bool CheckForLetter(char letter)
        {
            if (((int) letter >= 1072 && (int) letter <= 1103) || ((int) letter >= 1040 && (int) letter <= 1071) ||
                ((int) letter >= 97 && (int) letter <= 122) || ((int) letter >= 65 && (int) letter <= 90))
            {
                return true;
            }

            return false;
        }
    }
}