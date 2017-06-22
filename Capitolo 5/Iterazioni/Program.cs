/*
 * Programmare con C# 6 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 5: iterazioni
 */
using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;

            while (i < 10)
            {
                Console.WriteLine("i={0}", i);
                i++;
            }

            Console.WriteLine("fine while");

            i = 0;
            while (true)
            {
                Console.WriteLine("i={0}", i);
                if (++i==10)
                    break;
            }

            while (i < 10)
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine("i={0}", i);
            }

            //do while
            char c;
            do
            {
                Console.WriteLine("premi q per uscire");
                c=Console.ReadKey().KeyChar;
            }
            while(c!='q');
            Console.WriteLine("fine do");

            //for
            for(int a=0; a<10; a++)
            {
                Console.WriteLine("hello world");
            }

            int[] array=new int[10];
            for (int index = 0; index<array.Length; index++)
            {
                array[index] = index;
            }

            int[,] matrice = new int[10, 10];
            for (int riga = 0; riga < matrice.GetLength(0); riga++)
            {
                for (int colonna = 0; colonna < matrice.GetLength(1); colonna++)
                {
                    matrice[riga, colonna] = riga * colonna;
                    Console.Write("{0,5}",matrice[riga, colonna]);
                }
                Console.WriteLine();
            }

            matrice = new int[10, 10]; 
            for (int riga = 0, colonna = 0; riga < 10 && colonna < 10; riga++, colonna++)
            {
                Console.Write("{0,5}", riga*colonna);
            }


            string str = "aeio";
            foreach (var ch in str)
            {
                if (ch == 'a')
                    continue;
                Console.WriteLine(ch);
            }
            
            Console.ReadLine();
        }
    }
}
