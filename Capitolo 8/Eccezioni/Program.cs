/*
 * Programmare con C# 6 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 8: eccezioni
 */

using System;

namespace Eccezioni
{
    class Program
    {
        private static int Divide(int x, int y) => x / y;
    
        public static void Main()
        {
            int a = 10;
            int b = 0;
            int risultato = Divide(a, b);
            Console.WriteLine("{0}",risultato);
        }

        
    }
}
