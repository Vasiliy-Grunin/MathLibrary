namespace MathLibrary
{
    interface IVector
    {
        public bool Belongs(Segment segment);

        public double GetLength();

        public Vector Add(Vector add);
    }
}
