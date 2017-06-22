/*
 * Programmare con C# 6 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 4: domande riepilogo
 */

using System;

namespace DomandeRiepilogo
{
    class Program
    {
        static void Main(string[] args)
        {
            //domanda 1
            int a = 5;
            int b = 2;
            int c = a / b;
            Console.WriteLine(c);//=2 risposta a

            //domanda 2
            c = a & b;
            Console.WriteLine(c);//=0 risposta a

            //domanda 3
            a = 5;
            a*=2;
            Console.WriteLine(a);//=10 risposta c

            //domanda 4
            Domanda4();

            //domanda 5
            byte max = Byte.MaxValue;
            try
            {
                checked
                {
                    byte bb = (byte)(max + 1);
                }
            }
            catch
            {
                Console.WriteLine("risposta c, si verifica un'eccezione");
            }

            //domanda 6
            if(A() && B())
            {
            }
            Console.WriteLine("risposta d, entrambi");

            //domanda 7
            string str = "abc";
            int? len = str?.Length ?? 0;
            Console.WriteLine(len); //= 3 risposta c

            //domanda 8
            string n = nameof(Main); // risposta a, nameof introdotto con C# 6
            Console.ReadLine();
        }

        public static bool A()
        {
            Console.WriteLine("Eseguo A");
            return true;
        }

        public static bool B()
        {
            Console.WriteLine("Eseguo B");
            return false;
        }

        public static void Domanda4()
        {
            bool a = true;
            bool b = false;
            bool c = !(a && b);
            Console.WriteLine(c); //true, risposta b
            
        }
    }
}
