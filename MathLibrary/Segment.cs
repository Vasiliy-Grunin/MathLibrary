using System;

namespace MathLibrary
{
    public class Segment : ISegment
    {
        public Vector Begin { get; set; }
        public Vector End { get; set; }

        public Segment() { }

        public Segment(Vector begin, Vector end)
        {
            Begin = begin;
            End = end;
        }

        public double GetLength(Segment segment)
        {
            var x = (segment.End.X - segment.Begin.X) * (segment.End.X - segment.Begin.X);
            var y = (segment.End.Y - segment.Begin.Y) * (segment.End.Y - segment.Begin.Y);
            return Math.Sqrt(x + y);
        }

        public double GetLength(Vector begin, Vector end)
        {
            var x = (end.X - begin.X) * (end.X - begin.X);
            var y = (end.Y - begin.Y) * (end.Y - begin.Y);
            return Math.Sqrt(x + y);
        }

        public double GetLength()
        {
            return GetLength(this);
        }

        public bool Contains(Vector vetor)
            => Geometry.IsVectorInSegment(vetor, this);

        public double GetAreaCircle()
            => Geometry.GetAreaCircle(this);
    }
}
