using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strutture
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D p;

            p.X = 1;
            p.Y = 2;
            p.Z = 3;
            Console.WriteLine("({0},{1},{2})", p.X, p.Y, p.Z);
            
            ///Invocando il costruttore di default i campi sono inizializzati a 0
            Point3D p2 = new Point3D();
            Console.WriteLine("({0},{1},{2})", p2.X, p2.Y, p2.Z);

            //con il costruttore personalizzato inizializzo a 5 tutti i valori
            //p2 = new Point3D(5);
            //Console.WriteLine("({0},{1},{2})", p2.X, p2.Y, p2.Z);

            int[] array = new int[4];
        }

        static int Somma(int a, int b) => a + b;
    }

    struct Point3D
    {
        public double X;
        public double Y;
        public double Z;
        
        public Point3D(double d)
        {
            X = Y = Z = d;
        }
    }

}
