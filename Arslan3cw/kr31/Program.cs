using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;

namespace kr31
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<SimpleLongNumber> simpleLongNumbers = new List<SimpleLongNumber>();
            List<VeryLongNumber> veryLongNumbers = new List<VeryLongNumber>();

            for (int i = 0; i < Convert.ToInt32(Console.ReadLine()); i++)
            {
                VeryLongNumber n = new VeryLongNumber(Console.ReadLine());
                if (n.IsSimpleLongNumber())
                {
                    SimpleLongNumber n_sLN = new SimpleLongNumber(long.Parse(n.value));
                    simpleLongNumbers.Add(n_sLN);
                }
                else
                {
                    veryLongNumbers.Add(n);
                }
            }
            
            VeryLongNumber sum = new VeryLongNumber();
            
            
            
        }

        
        
    }

    class Number
    {
        public uint value { get; set; }
        
        public Number(uint value)
        {
            this.value = value;
        }

        public Number add(Number n)
        {
            return new Number(this.value + n.value);
        }

        public Number sub(Number n)
        {
            if(n.value > this.value)
            {
                Console.WriteLine("Ошибка!");
                return null;
            }
            return new Number(this.value - n.value);
        }

        public int compareTo(Number n)
        {
            if (this.value > n.value) return 1;
            if (this.value == n.value) return 0;
            return -1;
        }
        
        VeryLongNumber sum = new VeryLongNumber();
    }

    class SimpleLongNumber
    {
        public long value { get; set; }
        
        public SimpleLongNumber(long value)
        {
            this.value = value;
        }
        
    }

    class VeryLongNumber
    {
        public string value { get; set; }
        
        public VeryLongNumber(string value)
        {
            this.value = value;
        }
        public VeryLongNumber()
        {
            this.value = "0";
        }

        public bool IsSimpleLongNumber()
        {
            if (this.value.Length > 19)
            {
                return false;
            }
            if (this.value.Length < 19)
            {
                return true;
            }

            for (int i = 0; i < this.value.Length; i++)
            {
                if (this.value[i] > Convert.ToString(long.MaxValue)[i])
                {
                    return false;
                }
            }

            return true;
        }

        public VeryLongNumber add(VeryLongNumber n)
        {

            StringBuilder n1 = new StringBuilder(Reverse(this.value));
            StringBuilder n2 = new StringBuilder(Reverse(n.value));
            
            if (n1.Length > n2.Length)
            {
                while (n2.Length != n1.Length)
                {
                    n2.Append('0');
                }
            }
            else
            {
                while (n1.Length != n2.Length)
                {
                    n1.Append('0');
                }
            }
            
            var ost = 0;
            var chislo = 0;

            StringBuilder new_number = new StringBuilder("");
            

            for (int i = 0; i < Math.Max(n1.Length, n2.Length); i++)
            {
                n1[i] = Convert.ToChar((Convert.ToInt32(Convert.ToString(n1[i])) + Convert.ToInt32(Convert.ToString(n2[i]))) % 10);
                if((Convert.ToInt32(Convert.ToString(n1[i])) + Convert.ToInt32(Convert.ToString(n2[i])) > 10);
            }



        }
        public string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
    
    
}