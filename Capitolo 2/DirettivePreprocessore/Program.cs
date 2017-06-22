using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirettivePreprocessore
{
    class Program
    {
        static void Main(string[] args)
        {
            //modifica la configurazione di compilazione per utilizzare i simboli
#if DEBUG
            Console.WriteLine("modo debug");
#elif RELEASE
            Console.WriteLine("modo release");
#else
            Console.WriteLine("debug e release non definite");
#endif
        }
    }
}
