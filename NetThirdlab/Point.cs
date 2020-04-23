using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetThirdlab
{
    class Point
    {
        int x;
        int y;
        int z;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point() : this(0, 0, 0)
        {
        }
        public Point Addition(Point P)//+
        {
            int x = this.X + P.X;
            int y = this.Y + P.Y;
            int z = this.Z + P.Z;
            return new Point(x, y, z);
        }
        public int ScalarV(Point P)
        {
            return this.X * P.X + this.Y * P.Y + this.Z * P.Z;
        }
        public Point ProductV(Point P)//*
        {
            int x = (this.Y * P.Z) - (this.Z * P.Y );
            int y = (this.Z *  P.X) - (this.X * P.Z);
            int z = (this.X * P.Y) - (this.Y * P.X);
            return new Point(x, y, z);
        }
        public bool IsCollinearity(Point P)
        {
            double x = this.X / P.X;
            double y = this.Y / P.Y;
            if (x == y)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return " (" + this.X + "," + this.Y + "," + this.Z + ");";
        }
    }
}
