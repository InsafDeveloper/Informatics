using System;
using System.Runtime.Remoting;

namespace PerevodChisel
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число {number} в двоичной системе = {to(number,2)}");
            Console.WriteLine($"Число {number} в восьмеричной = {to(number,8)}");
            Console.WriteLine($"Число {number} в шестнадцатеричной системе = {to(number,16)}");
            
            Console.Write("Введите число которое хотите перевести из n-системы в 10-ричную систему:");
            string perevod_reverse = Console.ReadLine();
            Console.Write("Введите n:");
            int system = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число {perevod_reverse} в 10-системе = {from(perevod_reverse,system)}");
        }

        static string to(int number, int system)
        {
            string perevod = "";
            while (number != 0)
            {
                string ostatok = Convert.ToString(number % system);
                if (ostatok == "10") ostatok = "A";
                else if (ostatok == "11") ostatok = "B";
                else if (ostatok == "12") ostatok = "C";
                else if (ostatok == "13") ostatok = "D";
                else if (ostatok == "14") ostatok = "E";
                else if (ostatok == "15") ostatok = "F";
                perevod += ostatok;
                number = number / system;
            }

            string perevod_reverse = "";
            for (int i = perevod.Length - 1; i >= 0; i--)
            {
                perevod_reverse += perevod[i];
            }

            return perevod_reverse;
        }

        static double from(string perevod_reverse, int system)
        {
            string perevod = "";
            int ostatok;
            double number = 0;
            for (int i = perevod_reverse.Length - 1; i >= 0; i--)
            {
                perevod += perevod_reverse[i];
            }

            for (int i = 0; i < perevod.Length; i++)
            {
                string el = Convert.ToString(perevod[i]);
                if (el == "A") el = "10";
                else if (el == "B") el = "11";
                else if (el == "C") el = "12";
                else if (el == "D") el = "13";
                else if (el == "E") el = "14";
                else if (el == "F") el = "15";

                ostatok = int.Parse(el);

                number += ostatok * Math.Pow(system,i);
            }

            return number;
        }
    }
}