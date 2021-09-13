namespace MathLibrary
{
    public class Vector : IVector
    {
        public double X;
        public double Y;

        public Vector()
        {
        }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool Belongs(Segment segment)
            => Geometry.IsVectorInSegment(this, segment);

        public double GetLength()
            => Geometry.GetLength(this);

        public Vector Add(Vector add)
            => Geometry.Add(this, add);
    }
}
