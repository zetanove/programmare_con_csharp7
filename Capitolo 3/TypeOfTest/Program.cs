/*
 * Progrmmare con C# 6 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 3: operatore typeof
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            //ottenere un tipo
            Type t1 = i.GetType();
            Type t2 = typeof(int);
            Console.WriteLine(t1.FullName);
            Console.WriteLine(t2.FullName);

            //verifico se il tipo è primitivo, decimal non lo è
            Console.WriteLine(typeof(decimal).IsPrimitive);

            Console.ReadLine();
        }
    }
}
