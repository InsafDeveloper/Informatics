using static System.Console;
using System;
using System.Collections.Generic;

namespace Triangle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int k = Int32.Parse(ReadLine());
            List<int> ar = new List<int>();
            List<int> newAr = new List<int>();
            FillArray(ref ar, k);
            DeleteNumbers(ref ar, k, ref newAr);
            foreach (var elem in newAr)
            {
                Write(elem + " ");
            }
        }

        private static void FillArray(ref List<int> array, int k)
        {
            for (int i = 0; i < k; i++)
            {
                array.Add(GetUniqueNumber(array, k));
            }
        }

        private static void DeleteNumbers(ref List<int> array, int k, ref List<int> arr)
        {
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] % k - 1 != 0)
                {
                    arr.Add(array[i]);
                }
            }
        }


        private static int GetUniqueNumber(List<int> array, int k)
        {
            Random random = new Random();
            var n = random.Next(-k * 2 - 2, k * 2 - 3);
            while (!CheckForUnique(array, n))
            {
                n = random.Next(-k * 2 - 2, k * 2 - 3);
            }

            return n;
        }
        
        private static bool CheckForUnique(List<int> array, int n)
        {
            for (int i = 0; i < array.Count; i++)
            {
                if (Math.Abs(array[i]) == Math.Abs(n))
                    return false;
            }

            return true;
        }
        

    }
}
