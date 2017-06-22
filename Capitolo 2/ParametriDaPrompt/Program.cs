using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametriDaPrompt
{
    class Program
    {
        //Passa i parametri da riga di comando 
        //oppure dalle proprietà del progetto in Visual Studio
        // Debug -> Command Line Arguments
        static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                Console.WriteLine(args[0]);
                Console.WriteLine(args[1]);
            }
        }
    }
}
