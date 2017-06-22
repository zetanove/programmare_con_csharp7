/*
 * Progrmmare con C# 6 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 3: le classi
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    class Customer
    {
        public string name;
    }

    class Point
    {
        int x;
        int y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer drJekyll = new Customer();
            Customer mrHide;
            mrHide=drJekyll;
            if (mrHide == drJekyll)
                Console.WriteLine("mrHyde e drJekyll sono la stessa persona");

            drJekyll.name = "Henry";
            Console.WriteLine("{0} Jekyll", drJekyll.name);
            Console.WriteLine("{0} Hide", mrHide.name);

            mrHide = null;
            Console.WriteLine("{0} Jekyll", drJekyll.name);
            
            // la prossima scatenerebbe eccezione null reference
            //Console.WriteLine("{0} Hide", mrHide.name);

            //istanza di una classe
            Point p = new Point();

            //accesso ai membri di un oggetto
            string str = "hello world";
            int lunghezza = str.Length; //restituisce 11
            bool b = str.Contains("world"); //restituisce true
            Console.WriteLine(b);

            str = null;
            //se l'oggetto è null errore!
            //lunghezza = str.Length; 
        }
    }
}
