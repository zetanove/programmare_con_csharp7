/*
 * Programmare con C# 6 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 4: nameof
 */
using System;

namespace NameOf
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"esecuzione di {nameof(Main)}");
            string str = "hello";
            string name = nameof(str);
            Console.WriteLine(name);

            MiaClasse obj = new MiaClasse();
            Console.WriteLine(nameof(obj.Metodo1)); //stampa Metodo1

            Console.WriteLine(nameof(MiaClasse.Metodo1)); //restituisce Metodo1
            Console.WriteLine(nameof(Console.Title.Length));//restituisce Length
        }
    }

    class MiaClasse
    {
        public void Metodo1(int a) { }
    }
}
