using System;
using static System.Console;
using static System.Array;

namespace MathBoxSizes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
         InputData.Input();   
        }
    }

    class InputData
    {
        public static void Input()
        {
            WriteLine("Введите размеры бруса, разделяя каждый символ переносом строки (x, y, z)");
            Bar bar = new Bar(Double.Parse(ReadLine()), Double.Parse(ReadLine()), Double.Parse(ReadLine()));
            WriteLine("Введите размеры отверстия, разделяя каждый символ переносом строки (x, y)");
            Hole hole = new Hole(Double.Parse(ReadLine()), Double.Parse(ReadLine()));
            
            OutputData.Output(bar, hole);
        }
    }

    sealed class OutputData
    {
        public static void Output(Bar bar, Hole hole)
        {
            switch (Operations.CheckSizes(bar, hole))
            {
                case true:
                    WriteLine("Брус пролезет в отверстие");
                    break;
                case false:
                    WriteLine("Брус не пролезет в отверстие");
                    break;
            }
        }
        
    }
    
    sealed class Operations
    {
        public static bool CheckSizes(Bar bar, Hole hole)
        {
            return bar.sizeX <= hole.sizeX && bar.sizeY <= hole.sizeY;
        }
    }

    struct Bar
    {
        public readonly double sizeX;
        public readonly double sizeY;
        public readonly double sizeZ;

        public Bar(double x, double y, double z)
        {
            double[] sizes = {x, y, z};
            Sort(sizes);

            sizeX = sizes[0];
            sizeY = sizes[1];
            sizeZ = sizes[2];
        }
    }

    struct Hole
    {
        public readonly double sizeX;
        public readonly double sizeY;

        public Hole(double x, double y)
        {
            double[] sizes = {x, y};
            Sort(sizes);
            
            sizeX = sizes[0];
            sizeY = sizes[1];
        }
    }
}