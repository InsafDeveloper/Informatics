using System;
using static System.Math;
using static System.Console;


namespace Kr28
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Write("Введите a: "  );
            double a = Double.Parse(ReadLine());
            Write("Введите b: "  );
            double b = Double.Parse(ReadLine());
            Write("Введите n (шаг): "  );
            int n = Int32.Parse(ReadLine());
            
            WriteLine(CalculateIntegral(a, b, n));
        }
        
        private static double Function(double x)
        {   
            return 1/Sqrt(2*x*x+1.3);
        }
        
        private static double CalculateIntegral(double a, double b, int n)
        {
            double result, h;
            int i;
 
            h = (b-a)/n;
            result = 0;
 
            for(i = 1; i <= n; i++)
            {
                result += Function(a + h * i - h/2);
            }
            result *= h;
 
            return result;
        }
    }
}