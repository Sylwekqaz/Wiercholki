using System;
using System.Drawing;

namespace GraphPanel
{
    internal static class VectorOperationsHelper
    {
        public static double GetDistance(this PointF from, PointF to)
        {
            var dX = from.X - to.X;
            var dY = from.Y - to.Y;

            return Math.Sqrt(dX*dX + dY*dY);
        }

        public static PointF Orthogonal(this PointF vector)
        {
            return new PointF(-vector.Y, vector.X);
        }

        public static PointF Normalize(this PointF vector)
        {
            double lenght = Math.Sqrt(vector.X*vector.X + vector.Y*vector.Y);
            if (lenght == 0)
            {
                return vector;
            }

            return new PointF((float) (vector.X/lenght), (float) (vector.Y/lenght));
        }

        public static PointF Orthonormal(this PointF vector)
        {
            return Orthogonal(Normalize(vector));
        }

        public static PointF AddPoint(this PointF x, PointF y)
        {
            return new PointF(x.X + y.X, x.Y + y.Y);
        }

        public static PointF SubtractPoint(this PointF x, PointF y)
        {
            return AddPoint(x, y.NegativePoint());
        }

        public static PointF NegativePoint(this PointF x)
        {
            return new PointF(-x.X, -x.Y);
        }

        public static PointF MultiplyPoint(this PointF a, double b)
        {
            return new PointF((float) (a.X*b), (float) (a.Y*b));
        }
    }
}