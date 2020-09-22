using System;

namespace Infa
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] Massiv_Coef = GetCoefficents();
            int a = Massiv_Coef[0];
            int b = Massiv_Coef[1];
            int c = Massiv_Coef[2];

            double D = Convert.ToDouble(Math.Pow(b, 2)) - 4 * a * c;


            if (D < 0)
            {
                Console.WriteLine("Нет Решений");
            }
            else if (D == 0)
            {
                Console.WriteLine($"x = {Xminus(b, D, a)}");
            }
            else
            {
                Console.WriteLine($"x1 = {Xminus(b, D, a)}");
                Console.WriteLine($"x2 = {Xplus(b, D, a)}");
            }

        }

        static int[] GetCoefficents()
        {
            Console.WriteLine("Введите квадратное уравнение");
            string stroka = Console.ReadLine();

            string current_str = "";
            bool A = false;
            int a = 0;
            int b = 0;
            int c = 0;

            foreach (var el in stroka)
            {
                current_str += el;
                if (current_str.Contains("x^2"))
                {
                    current_str = current_str.Replace(" ", "");
                    current_str = current_str.Substring(0, current_str.Length - 3);
                    a = Coef(current_str);
                    A = true;
                    current_str = "";
                }

                if (A == true && current_str.Contains("x"))
                {
                    current_str = current_str.Replace(" ", "");
                    current_str = current_str.Substring(0, current_str.Length - 1);
                    b = Coef(current_str);
                    current_str = "";
                }
            }

            current_str = current_str.Replace(" ", "");

            try
            {
                c = Convert.ToInt32(current_str.Substring(0, current_str.Length - 2));
            }
            catch
            {
                c = 0;
            }

            return new[] {a, b, c};
        }

        static int Coef(string current_str)
        {
            int a = 0;

            if (current_str == "" || current_str == "+")
            {
                a = 1;
            }
            else if (current_str == "-")
            {
                a = -1;
            }
            else
            {
                a = Convert.ToInt32(current_str);
            }

            return a;
        }

        static double Xminus(int b, double D, int a)
        {
            return (-b - Math.Sqrt(D)) / Convert.ToDouble(2 * a);
        }

        static double Xplus(int b, double D, int a)
        {
            return (-b + Math.Sqrt(D)) / Convert.ToDouble(2 * a);
        }




        // сделать парсер
    }
}
