using System;
// ГОТОВ
namespace TrexznachnCifri
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            for (int i = 100; i < 1000; i++)
            {
                string a = Convert.ToString(i);
                if (((int.Parse(a[0].ToString())) + (int.Parse(a[1].ToString())) + (int.Parse(a[2].ToString()))) == n)
                {
                    x++;
                }
            }
            Console.WriteLine(x);
        }
    }
}