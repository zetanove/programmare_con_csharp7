using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    class LocalFunction
    {
        internal void Demo()
        {
            CalcolaFattoriali(10);
        }

        public void CalcolaFattoriali(int max)
        {
            for(int i=0;i<max;i++)
            {
                Console.WriteLine("fattoriale({0}) = {1}", i, Fattoriale(i));

                int Fattoriale(int num)
                {
                    Console.WriteLine("Sono all'interno del ciclo {0}", i); //closure
                    if (num <= 1)
                        return num;
                    return num * Fattoriale(num - 1); //moltiplica n per il risultato dello stesso metodo Fattoriale di n-1
                }
            
            }

        }
    }
}
