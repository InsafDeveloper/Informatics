using System;

namespace ClassLibrary1
{
    public class Class1
    { 
        static void Main(string[] args)
        {
            var text = args.Length > 0 && args[0]
                == "DE" ? "Hallo Welt!" : "Hello World!";
            Console.WriteLine(text)
        }
    }
}