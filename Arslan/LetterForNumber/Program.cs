using System;
// ГОТОВ
namespace LetterForNumber
{
    internal class Program
    {
        public static int number = 0;
        
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string word = "";
                for (int k = 0; k < words[i].Length; k++)
                {
                    if (CheckForLetter(words[i][k]))
                    {
                        number += 1;
                        word += Convert.ToString(number);
                    }
                    else word += words[i][k];
                }

                words[i] = word;
                Console.Write(word + " ");
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