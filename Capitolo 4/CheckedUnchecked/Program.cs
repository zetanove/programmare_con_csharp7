/*
 * Programmare con C# 6 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 4: checked unchecked
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckedUnchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 200;
            byte b2 = 150;
            byte somma =(byte)(b1 + b2);

            byte min = Byte.MinValue;
            byte underflow = (byte)(min-1);
            byte max = Byte.MaxValue;

            try
            {
                byte val = checked(max++);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
