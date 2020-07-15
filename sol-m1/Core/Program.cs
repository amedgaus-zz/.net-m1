using System;
using stlib;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0) Console.WriteLine(FormatterLibrary.FormatGreetings(args[0]));
        }
    }
}
