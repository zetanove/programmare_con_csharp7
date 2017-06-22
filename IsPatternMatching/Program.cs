using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TYPE PATTERN*/
            object obj = "Hello, world";

            if (obj is string str)
                Console.WriteLine($"lunghezza {str.Length}");

            //equivalente a 
            if (obj is string)
            {
                string s = (string)obj;
                Console.WriteLine($"lunghezza {s.Length}");
            }
        }
    }
}
