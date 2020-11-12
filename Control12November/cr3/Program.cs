using System;
using System.Globalization;
using System.IO;

namespace cr3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TextReader tr = new StreamReader("/Users/insafginiatov/RiderProjects/ConsoleApp/cr3/sample.txt");
            string myText = tr.ReadLine();
            while (myText != String.Empty)
            {
                myText = myText.ToLower(new CultureInfo("en-US", false));

                var ch = myText.ToCharArray();
                ch = Array.FindAll<char>(ch, (c => (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == '-')));
                myText = new string(ch);
                myText = DeleteSpaces(myText);
                if (CheckForPalindrom(myText))
                    Console.WriteLine("Da");
                else
                    Console.WriteLine("Net");
                myText = tr.ReadLine();
            }
            
        }

        private static bool CheckForPalindrom(string pal)
        {
            int i = 0;
            int j = pal.Length - 1;
            while (j >= 0)
            {
                if (!CheckForIdentity(pal[i], pal[j]))
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }

        private static bool CheckForIdentity(char f, char s)
        {
            return f == s;
        }

        private static string DeleteSpaces(string str)
        {
            string s = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    s += str[i];
            }

            return s;
        }
        
    }
}