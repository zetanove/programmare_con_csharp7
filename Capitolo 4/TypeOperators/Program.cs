/*
 * Programmare con C# 6 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 4: operatori di tipo
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            short sh = (short)i;//cast

            i = 1;
            object obj = i;
            int o = (int)obj; //obj viene riconvertito in int

            int? ii = null;

            if (ii is int)
            {
                Console.WriteLine(ii);
            }


            object j = 1;
            if (j is int)
            {
                Console.WriteLine("j is int");
            }

            int z = (int)j;
            if (z is int)
            {
            }

            object objt = new Tipo();
            Tipo t;
            if (objt is Tipo)
            {
                 t = objt as Tipo;
            }
            else t = null;
        }
    }

    class Tipo
    {

    }
}
