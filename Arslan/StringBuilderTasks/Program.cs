using System;
using System.Text;

namespace StringBuilderTasks
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task1();
            Task2();
        }
        

        static void Task1()
        {
            string a = Console.ReadLine();
            int count = 0;
            foreach (var el in a)
            {
                int number = Convert.ToInt32(el);
                if ((number >= 97 && number <= 122) || (number >= 65 && number <= 90))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        static void Task2()
        {
            StringBuilder a = new StringBuilder(Console.ReadLine());
            a.Replace("mom", "dad");
            Console.WriteLine(a);
        }
    }
}