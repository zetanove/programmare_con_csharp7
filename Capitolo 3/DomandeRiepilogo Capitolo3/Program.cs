/*
 * Progrmmare con C# 6 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 3: domande riepilogo
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomandeRiepilogo_Capitolo3
{
    struct Struct1
    {
        //domanda 1: falso
        //Struct1()
        //{ }
    }
    class Program
    {
        
          
        static void Main(string[] args)
        {
            //domanda 2: d
            Persona persona = new Persona();
            string n = persona.Nome;

            //domanda 3: c
            Giorni g = Giorni.Dom;
            Console.WriteLine((int)g);

            float f = 0.0F;
            //domanda 5: a
            //non è possibile convertire implicitamente
            //int i = f;

            object obj = 123;
            //domanda 6: b
            Type t = obj.GetType();
            Console.WriteLine(t);

            //domanda 7: c
            int[] array = new int[5];
            array[4] = 1;

            Console.ReadLine();
        }
    }

    class Persona
    {
        public string Nome { get; set; }
    }

    enum Giorni { Lun = 1, Mar, Mer, Gio, Ven, Sab, Dom };
}
