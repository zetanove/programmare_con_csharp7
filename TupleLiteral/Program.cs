using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleLiteral
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, string) tupla = (1, "Matilda"); //Tuple.Create<int, string>(1, "");

            Coordinate coord = new Coordinate("Roma", 41.891930, 12.5113300);

            var (città, lat, lon) = coord;
        }
    }

    public class Coordinate
    {
        public string Città { get; }
        public double Latitudine { get; }
        public double Longitudine { get; }

        public Coordinate(string città, double lat, double lon)
        {
            Città = città;
            Latitudine = lat;
            Longitudine = lon;
        }

        public void Deconstruct(out string città, out double latitudine, out double longitudine)
        {
            città = this.Città;
            latitudine = this.Latitudine;
            longitudine = this.Longitudine;
        }
    }

}
