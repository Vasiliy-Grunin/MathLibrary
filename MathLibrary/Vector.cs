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
            => Geometry.IsVectorInSegment(new Vector(X, Y), segment);

        public double GetLength()
            => Geometry.GetLength(new Vector(X, Y));

        public Vector Add(Vector add)
            => Geometry.Add(new Vector(X, Y), add);
    }
}
