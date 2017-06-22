using static System.Console;

namespace Using
{
    using System;
    using static Nuovo.Console2;

    class Program
    {
        static void Main(string[] args)
        {
            Title = "Esempio Console I/O";
            BackgroundColor = ConsoleColor.White;
            Clear();
            ForegroundColor = ConsoleColor.Blue;
            Write(" Hello World");

            WriteLine("Uso la classe Console2");
            ReadKey();
        }
    }
}

namespace Nuovo
{
    public class Console2
    {
        public static void WriteLine(string a)
        {
            System.Console.WriteLine("Console2.WriteLine("+a+")");
        }
    }
}