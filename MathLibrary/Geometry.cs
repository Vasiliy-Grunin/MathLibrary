using System;

namespace MathLibrary
{
    public static class Geometry
    {
        public static double GetLength(Vector vector)
            => Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);

        public static Vector Add(Vector startPoint, Vector endPoint)
            => new(startPoint.X + endPoint.X, startPoint.Y + endPoint.Y);

        public static double GetLength(Segment segment)
        {
            var x = (segment.End.X - segment.Begin.X) * (segment.End.X - segment.Begin.X);
            var y = (segment.End.Y - segment.Begin.Y) * (segment.End.Y - segment.Begin.Y);
            return Math.Sqrt(x + y);
        }

        public static double GetAreaCircle(Segment segment)
            => Math.PI * GetLength(segment) * GetLength(segment);

        public static bool IsVectorInSegment(Vector vector, Segment segment)
        {
            return GetLength(new Segment(segment.Begin, vector))
                + GetLength(new Segment(vector, segment.End))
                == GetLength(segment);
        }

        public static double GetAreaTriangle(Vector a, Vector b, Vector c)
            => Math.Abs((a.X * (b.Y - c.Y) + b.X * (c.Y - a.Y) + c.X * (a.Y - b.Y)) / 2);

        public static bool CheckRightAngle(Vector a, Vector b)
            => Math.Acos((a.X * b.X + a.Y * b.Y) / (GetLength(a) * GetLength(b))) == Math.PI / 2;

        public static bool CheckRightAngle(Vector a, Vector b, Vector c)
            => CheckRightAngle(a, b) || CheckRightAngle(b, c) || CheckRightAngle(c, a);
    }
}
