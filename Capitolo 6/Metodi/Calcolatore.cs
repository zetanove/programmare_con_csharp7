using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    class Calcolatore
    {
        public void PassByValue(int i)
        {
            i++;
            Console.WriteLine("i={0}", i);
        }

        public void PassByRef(ref int i)
        {
            i++;
            Console.WriteLine("i={0}", i);
        }

        internal double Potenza(double numero, int esponente)
        {
            double risultato = numero;
            for (int i = 1; i < esponente; i++)
            {
                risultato *= numero;
            }
            return risultato;

        }

        //C# 6: espressioni corpo
        public int Somma(int a, int b) => a + b;
    }
}
