using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        

        public override string ToString()
        {
            return base.ToString();
        }


        public Point AddToPoint(Point pt)
        {
            pt.X += this.X;
            pt.Y += this.Y;
            return pt;
        }

        public Point AddToPoint(ref Point pt)
        {
            pt.X += this.X;
            pt.Y += this.Y;
            return pt;
        }
    }
}
