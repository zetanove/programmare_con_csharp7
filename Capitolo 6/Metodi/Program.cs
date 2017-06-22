/*
 * Programmare con C# 6 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 6: metodi
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    class Uomo
    {
        public int altezza=170;
    }

    class Program
    {
        static void CambiaAltezza(Uomo uomo)
        {
            Console.WriteLine("prima dell'assegnazione: {0}", uomo.altezza);
            uomo.altezza = 180;
            Console.WriteLine("dopo l'assegnazione: {0}", uomo.altezza);
        }

        static void CambiaAltezza2(Uomo uomo)
        {
            Console.WriteLine("prima dell'assegnazione: {0}", uomo.altezza);
            uomo = new Uomo();
            uomo.altezza = 180;
            Console.WriteLine("dopo l'assegnazione: {0}", uomo.altezza);
        }

        static void CambiaAltezza2(ref Uomo uomo)
        {
            Console.WriteLine("prima dell'assegnazione: {0}", uomo.altezza);
            uomo = new Uomo();
            uomo.altezza = 180;
            Console.WriteLine("dopo l'assegnazione: {0}", uomo.altezza);
        }

        static void PotenzeMultiple(int val, out int potenza2, out int potenza3)
        {
            potenza2 = val * val;
            potenza3 = potenza2 * val;
        }

        static double CalcolaMedia(params double[] array)
        {
            double media = 0;
            for (int i = 0; i < array.Length; i++)
            {
                media += array[i];
            }
            return media / array.Length;
        }

        static int Optional(int a = 0, int b = 1)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            double numero = 2;
            int esponente = 4;
            Calcolatore calc = new Calcolatore();
            Console.WriteLine("numero={0}, esponente={1}", numero, esponente);
            double risultato = calc.Potenza(numero, esponente);
            Console.WriteLine("{0}^{1}={2}", numero, esponente, risultato);
            Console.WriteLine("numero={0}, esponente={1}, risultato={2}", numero, esponente, risultato);
                
            int i=1;
            calc.PassByValue(i);
            Console.WriteLine("i={0}", i);

            calc.PassByRef(ref i);
            Console.WriteLine("i={0}", i);

            Uomo uomo = new Uomo();
            Console.WriteLine("prima del metodo: {0}", uomo.altezza);
            CambiaAltezza(uomo);
            Console.WriteLine("dopo metodo: {0}", uomo.altezza);

            uomo = new Uomo();
            Console.WriteLine("prima del metodo: {0}", uomo.altezza);
            CambiaAltezza2(uomo);
            Console.WriteLine("dopo metodo: {0}", uomo.altezza);

            uomo = new Uomo();
            Console.WriteLine("prima del metodo: {0}", uomo.altezza);
            CambiaAltezza2(ref uomo);
            Console.WriteLine("dopo metodo: {0}", uomo.altezza);

            int p2,p3;
            PotenzeMultiple(4, out p2, out p3);

            double media=CalcolaMedia(1, 2, 3.4, 6, 9.2);
            media = CalcolaMedia(new double[] {2, 4, 5.9, 33.9 });
            double d= CalcolaMedia();

            int sum = Optional(1);
            sum = Optional(b: 2);

            int somma=calc.Somma(2, 3);


            Ricorsione ric = new Ricorsione();
            var fatt=ric.Fattoriale(5);
            Console.WriteLine(fatt);
        }
    }
}
