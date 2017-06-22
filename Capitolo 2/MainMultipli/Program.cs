using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dalle proprietà del progetto è possibile configurare quale metodo Main utilizzare come punto di ingresso dell'applicazione

// per compilare da riga di comando con csc indicare quale metodo Main utilizzare con l'opzione /main:
// csc /main:MainMultipli.Program Program.cs
namespace MainMultipli
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }

    class Program2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World 2");
        }
    }

}
