using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSample
{
    public readonly struct Vector
    {
        public Vector(double x, double y, double z) => (X, Y, Z) = (x, y, z);
        public Vector(Vector v) => (X, Y, Z) = (v.X, v.Y, v.Z);

        public readonly double X;
        public readonly double Y;
        public readonly double Z;

        public static Vector operator +(Vector left, Vector right) =>
            new Vector(left.X + right.X, left.Y + right.Y, left.Z + right.Z);

    }
}
