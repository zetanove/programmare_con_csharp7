/*
 * Programmare con C# 6 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 5: istruzione switch
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstruzioneSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;

            int num = 1;
            switch (num )
            {
                case 1:
                    
                    b = false;
                    goto case 2;
                case 2:
                    break;
            }

            //switch con string case sensitive
            string str = "";
            switch (str)
            {
                case "a":
                    break;
                case "A":
                    break;
            }

            //fall through
            Console.WriteLine("digita un tasto");
            char c = Console.ReadKey().KeyChar;
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("hai digitato la vocale {0}", c);
                    break;
                default:
                    Console.WriteLine("non hai inserito una vocale");
                    break;
            }

            DayOfWeek day = DateTime.Today.DayOfWeek;

            switch(day)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("riposo");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("8:00 - 12:00");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("8:00 - 12:00 e 15:00 - 18:00");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("8:00 - 12:00");
                    break;
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("8:00 - 12:00");
                    break;
            }


        }

    }
}
