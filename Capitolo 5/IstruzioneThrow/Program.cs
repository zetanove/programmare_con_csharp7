/*
 * Programmare con C# 6 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 5: istruzione throw
 */
using System;

namespace IstruzioneThrow
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                throw new ArgumentNullException();
            }

            Console.Write("{0} argomenti", args.Length); // se l'eccezione viene lanciata non si arriverà mai a questa linea
        }
    }
}
